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
            CopySelectedFiles(lvwLeftDir, txtLeftDir.Text, txtRightDir.Text);
        }

        private void btnCopyFromRight_Click_1(object sender, EventArgs e)
        {
            CopySelectedFiles(lvwRightDir, txtRightDir.Text, txtLeftDir.Text);
        }

        private void CopySelectedFiles(ListView sourceLV, string sourceDir, string destDir)
        {
            // 양쪽 경로가 모두 있는지 확인
            if (string.IsNullOrWhiteSpace(sourceDir) || string.IsNullOrWhiteSpace(destDir))
            {
                MessageBox.Show("양쪽 폴더가 모두 선택되어 있어야 합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Directory.Exists(destDir))
            {
                MessageBox.Show("대상 폴더가 존재하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sourceLV.SelectedItems.Count == 0)
            {
                MessageBox.Show("복사할 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool refreshNeeded = false;

            foreach (ListViewItem item in sourceLV.SelectedItems)
            {
                bool isDir = item.SubItems.Count > 1 && item.SubItems[1].Text == "<DIR>";
                string itemName = item.Text;
                string sourcePath = Path.Combine(sourceDir, itemName);
                string destPath = Path.Combine(destDir, itemName);

                if (isDir)
                {
                    CopyDirectoryRecursively(sourcePath, destPath, ref refreshNeeded);
                }
                else
                {
                    CopySingleFile(sourcePath, destPath, itemName, ref refreshNeeded);
                }
            }

            // 복사된 파일이 하나라도 있으면 양쪽 리스트 모두 새로고침
            if (refreshNeeded)
            {
                PopulateListView(lvwLeftDir, txtLeftDir.Text);
                PopulateListView(lvwRightDir, txtRightDir.Text);
                CompareFiles();
            }
        }

        private void CopySingleFile(string sourcePath, string destPath, string fileName, ref bool refreshNeeded)
        {
            // 대상 경로에 파일이 이미 존재하는 경우 날짜 확인
            if (File.Exists(destPath))
            {
                DateTime sourceTime = File.GetLastWriteTime(sourcePath);
                DateTime destTime = File.GetLastWriteTime(destPath);

                // 복사하려는 원본 파일이 대상 파일보다 오래된 경우
                if (sourceTime < destTime)
                {
                    var result = MessageBox.Show(
                        $"'{fileName}' 파일은 대상 폴더의 파일보다 지연된(오래된) 파일입니다.\n이전 버전의 파일로 덮어쓰시겠습니까?",
                        "확인",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result != DialogResult.Yes)
                    {
                        return; // 복사 취소
                    }
                }
            }

            try
            {
                // 덮어쓰기 허용하여 복사
                File.Copy(sourcePath, destPath, true);
                refreshNeeded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"'{fileName}' 복사 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyDirectoryRecursively(string sourcePath, string destPath, ref bool refreshNeeded)
        {
            try
            {
                if (!Directory.Exists(destPath))
                {
                    Directory.CreateDirectory(destPath);
                    refreshNeeded = true;
                }

                // 폴더 내 파일 복사
                foreach (string file in Directory.GetFiles(sourcePath))
                {
                    string destFile = Path.Combine(destPath, Path.GetFileName(file));
                    CopySingleFile(file, destFile, Path.GetFileName(file), ref refreshNeeded);
                }

                // 하위 폴더 재귀 복사
                foreach (string dir in Directory.GetDirectories(sourcePath))
                {
                    string destDir = Path.Combine(destPath, Path.GetFileName(dir));
                    CopyDirectoryRecursively(dir, destDir, ref refreshNeeded);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"폴더 복사 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            // Details 뷰에서는 서브아이템(DrawSubItem)에서 배경과 텍스트를 모두 그리므로 생략합니다.
        }

        private void ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            bool isSelected = e.Item.Selected;

            // 선택 상태에 따른 커스텀 배경 그리기
            if (isSelected)
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

            // 앞서 CompareFiles()에서 결정된 ForeColor 값 적용
            Color textColor = isSelected ? SystemColors.HighlightText : e.Item.ForeColor;

            // TextRenderer 대신 DrawString을 사용하여 Hover 시 사라지는 문제 방지
            Rectangle textBounds = new Rectangle(e.Bounds.X + 4, e.Bounds.Y, e.Bounds.Width - 4, e.Bounds.Height);
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Center;
                sf.FormatFlags = StringFormatFlags.NoWrap;
                sf.Trimming = StringTrimming.EllipsisCharacter;

                using (SolidBrush textBrush = new SolidBrush(textColor))
                {
                    e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, textBrush, textBounds, sf);
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



