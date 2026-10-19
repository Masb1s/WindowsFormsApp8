namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.друкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копіюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.копіюватиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(921, 483);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копіюватиToolStripMenuItem1,
            this.вирізатиToolStripMenuItem1,
            this.вставитиToolStripMenuItem1,
            this.шрифтToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem,
            this.зберегтиToolStripMenuItem,
            this.друкToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // друкToolStripMenuItem
            // 
            this.друкToolStripMenuItem.Name = "друкToolStripMenuItem";
            this.друкToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.друкToolStripMenuItem.Text = "Друк";
            this.друкToolStripMenuItem.Click += new System.EventHandler(this.друкToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копіюватиToolStripMenuItem,
            this.вирізатиToolStripMenuItem,
            this.вставитиToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // копіюватиToolStripMenuItem
            // 
            this.копіюватиToolStripMenuItem.Name = "копіюватиToolStripMenuItem";
            this.копіюватиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.копіюватиToolStripMenuItem.Text = "Копіювати";
            this.копіюватиToolStripMenuItem.Click += new System.EventHandler(this.копіюватиToolStripMenuItem_Click);
            // 
            // вирізатиToolStripMenuItem
            // 
            this.вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            this.вирізатиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вирізатиToolStripMenuItem.Text = "Вирізати";
            this.вирізатиToolStripMenuItem.Click += new System.EventHandler(this.вирізатиToolStripMenuItem_Click);
            // 
            // вставитиToolStripMenuItem
            // 
            this.вставитиToolStripMenuItem.Name = "вставитиToolStripMenuItem";
            this.вставитиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вставитиToolStripMenuItem.Text = "Вставити";
            this.вставитиToolStripMenuItem.Click += new System.EventHandler(this.вставитиToolStripMenuItem_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проАвтораToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // проАвтораToolStripMenuItem
            // 
            this.проАвтораToolStripMenuItem.Name = "проАвтораToolStripMenuItem";
            this.проАвтораToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проАвтораToolStripMenuItem.Text = "Про автора";
            this.проАвтораToolStripMenuItem.Click += new System.EventHandler(this.проАвтораToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(921, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // копіюватиToolStripMenuItem1
            // 
            this.копіюватиToolStripMenuItem1.Name = "копіюватиToolStripMenuItem1";
            this.копіюватиToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.копіюватиToolStripMenuItem1.Text = "Копіювати";
            // 
            // вирізатиToolStripMenuItem1
            // 
            this.вирізатиToolStripMenuItem1.Name = "вирізатиToolStripMenuItem1";
            this.вирізатиToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.вирізатиToolStripMenuItem1.Text = "Вирізати";
            // 
            // вставитиToolStripMenuItem1
            // 
            this.вставитиToolStripMenuItem1.Name = "вставитиToolStripMenuItem1";
            this.вставитиToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.вставитиToolStripMenuItem1.Text = "Вставити";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 507);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem друкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проАвтораToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
    }
}

