namespace FileCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // DrawItem 이벤트를 사용하기 위해 OwnerDraw 활성화 및 핸들러 연결
            lvwLeftDir.OwnerDraw = true;
            lvwLeftDir.DrawColumnHeader += ListView_DrawColumnHeader;
            lvwLeftDir.DrawItem += ListView_DrawItem;
            lvwLeftDir.DrawSubItem += ListView_DrawSubItem;

            lvwRightDir.OwnerDraw = true;
            lvwRightDir.DrawColumnHeader += ListView_DrawColumnHeader;
            lvwRightDir.DrawItem += ListView_DrawItem;
            lvwRightDir.DrawSubItem += ListView_DrawSubItem;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCopyFromLeft_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCopyFromRight_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLeftDir_Click_1(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를  선택하세요.";
                // 현재 텍스트박스에 있는 경로를 초기 선택 폴더로 설정 if (!string.IsNullOrWhiteSpace(txtLeftDir.Text) &&
                Directory.Exists(txtLeftDir.Text);
                {
                    dlg.SelectedPath = txtLeftDir.Text;
                }
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtLeftDir.Text = dlg.SelectedPath;
                    PopulateListView(lvwLeftDir, dlg.SelectedPath);
                    CompareFiles();
                }
            }
        }

        private void btnRightDir_Click_1(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "폴더를  선택하세요.";
                // 현재 텍스트박스에 있는 경로를 초기 선택 폴더로 설정 if (!string.IsNullOrWhiteSpace(txtLeftDir.Text) &&
                Directory.Exists(txtRightDir.Text);
                {
                    dlg.SelectedPath = txtRightDir.Text;
                }
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtRightDir.Text = dlg.SelectedPath;
                    PopulateListView(lvwRightDir, dlg.SelectedPath);
                    CompareFiles();
                }
            }
        }
        private void PopulateListView(ListView lv, string folderPath)
        {
            lv.BeginUpdate();
            lv.Items.Clear();
            try
            { // 폴더(디렉터리) 먼저  추가
                var dirs = Directory.EnumerateDirectories(folderPath)
                .Select(p => new DirectoryInfo(p))
                .OrderBy(d => d.Name);
                foreach (var d in dirs)
                {
                    var item = new ListViewItem(d.Name);
                    item.SubItems.Add("<DIR>");
                    item.SubItems.Add(d.LastWriteTime.ToString("g"));
                    lv.Items.Add(item);
                }
                // 파일  추가
                var files = Directory.EnumerateFiles(folderPath)
                .Select(p => new FileInfo(p))
                .OrderBy(f => f.Name);
                foreach (var f in files)
                {
                    var item = new ListViewItem(f.Name);
                    item.SubItems.Add(f.Length.ToString("N0") + " 바이트");
                    item.SubItems.Add(f.LastWriteTime.ToString("g"));
                    lv.Items.Add(item);
                }
                // 컬럼  너비  자동  조정  (컨텐츠  기준)
                for (int i = 0; i < lv.Columns.Count; i++)
                {
                    lv.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(this, "폴더를  찾을  수  없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, "입출력  오류: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lv.EndUpdate();
            }

        }


        private void CompareFiles()
        {
            if (lvwLeftDir == null || lvwRightDir == null) return;

            // 오른쪽 항목들을 Dictionary로 만들어 검색 속도를 높이고 코드를 간결하게 만듭니다.
            var rightItems = lvwRightDir.Items.Cast<ListViewItem>().ToDictionary(i => i.Text);

            foreach (ListViewItem leftItem in lvwLeftDir.Items)
            {
                if (rightItems.TryGetValue(leftItem.Text, out var rightItem))
                {
                    DateTime.TryParse(leftItem.SubItems[2].Text, out DateTime leftDate);
                    DateTime.TryParse(rightItem.SubItems[2].Text, out DateTime rightDate);

                    if (leftItem.SubItems[1].Text == rightItem.SubItems[1].Text && leftDate == rightDate)
                    {
                        leftItem.ForeColor = rightItem.ForeColor = Color.Black; // 완전 동일한 파일
                    }
                    else if (leftDate > rightDate)
                    {
                        leftItem.ForeColor = Color.Red;   // 최신 파일 (New)
                        rightItem.ForeColor = Color.Gray; // 구형 파일 (Old)
                    }
                    else if (rightDate > leftDate)
                    {
                        leftItem.ForeColor = Color.Gray;  // 구형 파일 (Old)
                        rightItem.ForeColor = Color.Red;  // 최신 파일 (New)
                    }
                    else
                    {
                        leftItem.ForeColor = rightItem.ForeColor = Color.Red; // 크기만 다르고 날짜가 같을 경우
                    }

                    rightItems.Remove(leftItem.Text); // 비교 완료된 항목 제거
                }
                else
                {
                    leftItem.ForeColor = Color.Purple; // 왼쪽에만 있는 단독 파일
                }
            }

            // 딕셔너리에 남은 항목들은 오른쪽에만 있는 단독 파일
            foreach (var rightItem in rightItems.Values)
            {
                rightItem.ForeColor = Color.Purple;
            }
        }


        private void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true; // 컬럼 헤더는 OS 기본 방식으로 그리기
        }

        private void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // Details 뷰에서는 서브아이템(DrawSubItem)에서 실제 텍스트를 그리므로 여기서는 배경만 처리
            e.DrawBackground();
        }

        private void ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // 선택된 항목에 대한 배경색 처리
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
            }
            else
            {
                using (var bgBrush = new SolidBrush(e.Item.BackColor))
                {
                    e.Graphics.FillRectangle(bgBrush, e.Bounds);
                }
            }

            // 앞서 CompareFiles()에서 결정된 ForeColor 값을 가져와서 직접 브러쉬로 그리기
            Color textColor = e.Item.Selected ? SystemColors.HighlightText : e.Item.ForeColor;

            Rectangle textBounds = new Rectangle(e.Bounds.X + 2, e.Bounds.Y, e.Bounds.Width - 2, e.Bounds.Height);
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis;

            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.Item.Font, textBounds, textColor, flags);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



