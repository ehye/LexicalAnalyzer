namespace MyComplier
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LexingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParsingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Txt_lex = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Txt_input = new System.Windows.Forms.RichTextBox();
            this.Txt_row = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1017, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FToolStripMenuItem,
            this.LexingToolStripMenuItem,
            this.ParsingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LexingToolStripMenuItem
            // 
            this.LexingToolStripMenuItem.Name = "LexingToolStripMenuItem";
            this.LexingToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.LexingToolStripMenuItem.Text = "&Lexing";
            this.LexingToolStripMenuItem.Click += new System.EventHandler(this.LexingToolStripMenuItem_Click);
            // 
            // ParsingToolStripMenuItem
            // 
            this.ParsingToolStripMenuItem.Name = "ParsingToolStripMenuItem";
            this.ParsingToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.ParsingToolStripMenuItem.Text = "&Parsing";
            this.ParsingToolStripMenuItem.Click += new System.EventHandler(this.ParsingToolStripMenuItem_Click);
            // 
            // Txt_lex
            // 
            this.Txt_lex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(40)))));
            this.Txt_lex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_lex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_lex.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.Txt_lex.ForeColor = System.Drawing.Color.White;
            this.Txt_lex.Location = new System.Drawing.Point(435, 4);
            this.Txt_lex.Name = "Txt_lex";
            this.Txt_lex.ReadOnly = true;
            this.Txt_lex.Size = new System.Drawing.Size(578, 265);
            this.Txt_lex.TabIndex = 2;
            this.Txt_lex.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(40)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(435, 276);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(578, 266);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Txt_lex, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Txt_input, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Txt_row, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 546);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Txt_input
            // 
            this.Txt_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(40)))));
            this.Txt_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_input.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_input.ForeColor = System.Drawing.Color.White;
            this.Txt_input.Location = new System.Drawing.Point(45, 4);
            this.Txt_input.Name = "Txt_input";
            this.tableLayoutPanel1.SetRowSpan(this.Txt_input, 2);
            this.Txt_input.Size = new System.Drawing.Size(383, 538);
            this.Txt_input.TabIndex = 1;
            this.Txt_input.Text = "";
            this.Txt_input.TextChanged += new System.EventHandler(this.Txt_input_TextChanged);
            this.Txt_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_input_KeyDown);
            this.Txt_input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_input_KeyUp);
            this.Txt_input.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_input_MouseDown);
            // 
            // Txt_row
            // 
            this.Txt_row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.Txt_row.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_row.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_row.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.Txt_row.HideSelection = false;
            this.Txt_row.Location = new System.Drawing.Point(4, 4);
            this.Txt_row.Multiline = true;
            this.Txt_row.Name = "Txt_row";
            this.Txt_row.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.Txt_row, 2);
            this.Txt_row.Size = new System.Drawing.Size(34, 538);
            this.Txt_row.TabIndex = 6;
            this.Txt_row.TabStop = false;
            this.Txt_row.Text = "1";
            this.Txt_row.WordWrap = false;
            // 
            // FToolStripMenuItem
            // 
            this.FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NToolStripMenuItem,
            this.OToolStripMenuItem,
            this.toolStripSeparator,
            this.SToolStripMenuItem,
            this.AToolStripMenuItem,
            this.toolStripSeparator1,
            this.XToolStripMenuItem});
            this.FToolStripMenuItem.Name = "FToolStripMenuItem";
            this.FToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.FToolStripMenuItem.Text = "&File";
            // 
            // NToolStripMenuItem
            // 
            this.NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NToolStripMenuItem.Image")));
            this.NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NToolStripMenuItem.Name = "NToolStripMenuItem";
            this.NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.NToolStripMenuItem.Text = "&New";
            // 
            // OToolStripMenuItem
            // 
            this.OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OToolStripMenuItem.Image")));
            this.OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OToolStripMenuItem.Name = "OToolStripMenuItem";
            this.OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.OToolStripMenuItem.Text = "&Open";
            this.OToolStripMenuItem.Click += new System.EventHandler(this.OToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(152, 6);
            // 
            // SToolStripMenuItem
            // 
            this.SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SToolStripMenuItem.Image")));
            this.SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SToolStripMenuItem.Name = "SToolStripMenuItem";
            this.SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.SToolStripMenuItem.Text = "&Save";
            this.SToolStripMenuItem.Click += new System.EventHandler(this.SToolStripMenuItem_Click);
            // 
            // AToolStripMenuItem
            // 
            this.AToolStripMenuItem.Name = "AToolStripMenuItem";
            this.AToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.AToolStripMenuItem.Text = "Save &As";
            this.AToolStripMenuItem.Click += new System.EventHandler(this.AToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // XToolStripMenuItem
            // 
            this.XToolStripMenuItem.Name = "XToolStripMenuItem";
            this.XToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.XToolStripMenuItem.Text = "E&xit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1017, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "MyComplier";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox Txt_lex;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem LexingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParsingToolStripMenuItem;
        private System.Windows.Forms.RichTextBox Txt_input;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Txt_row;
        private System.Windows.Forms.ToolStripMenuItem FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem XToolStripMenuItem;
    }
}

