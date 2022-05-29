namespace Example
{
   partial class Form1
   {
      /// <summary>
      /// Обязательная переменная конструктора.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Освободить все используемые ресурсы.
      /// </summary>
      /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Код, автоматически созданный конструктором форм Windows

      /// <summary>
      /// Требуемый метод для поддержки конструктора — не изменяйте 
      /// содержимое этого метода с помощью редактора кода.
      /// </summary>
      private void InitializeComponent()
      {
         System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел1");
         System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Узел0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
         System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Узел3");
         System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Узел4");
         System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Узел2", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
         this.rynteTextBox1 = new Rynte.UI2.RynteTextBox();
         this.rynteTextBox2 = new Rynte.UI2.RynteTextBox();
         this.rynteTabControl1 = new Rynte.UI2.RynteTabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.rynteTreeView1 = new Rynte.UI2.RynteTreeView();
         this.rynteComboBox1 = new Rynte.UI2.RynteComboBox();
         this.rynteComboBox2 = new Rynte.UI2.RynteComboBox();
         this.rynteComboBox3 = new Rynte.UI2.RynteComboBox();
         this.rynteTabControl1.SuspendLayout();
         this.SuspendLayout();
         // 
         // rynteTextBox1
         // 
         this.rynteTextBox1.BackColor = System.Drawing.Color.White;
         this.rynteTextBox1.BorderColor = System.Drawing.Color.Fuchsia;
         this.rynteTextBox1.BorderMode = Rynte.UI2.Enums.BorderMode.Default;
         this.rynteTextBox1.BorderSize = 1;
         this.rynteTextBox1.DefaultText = "";
         this.rynteTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.rynteTextBox1.HoverState.BorderSize = 1;
         this.rynteTextBox1.Location = new System.Drawing.Point(13, 47);
         this.rynteTextBox1.Margin = new System.Windows.Forms.Padding(4);
         this.rynteTextBox1.Multiline = true;
         this.rynteTextBox1.Name = "rynteTextBox1";
         this.rynteTextBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.rynteTextBox1.PasswordChar = false;
         this.rynteTextBox1.Placeholder = null;
         this.rynteTextBox1.ReadOnly = false;
         this.rynteTextBox1.Size = new System.Drawing.Size(218, 94);
         this.rynteTextBox1.TabIndex = 0;
         // 
         // rynteTextBox2
         // 
         this.rynteTextBox2.BackColor = System.Drawing.Color.White;
         this.rynteTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.rynteTextBox2.BorderMode = Rynte.UI2.Enums.BorderMode.Underline;
         this.rynteTextBox2.BorderSize = 1;
         this.rynteTextBox2.DefaultText = "";
         this.rynteTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.rynteTextBox2.HoverState.BorderSize = 1;
         this.rynteTextBox2.Location = new System.Drawing.Point(13, 13);
         this.rynteTextBox2.Margin = new System.Windows.Forms.Padding(4);
         this.rynteTextBox2.Multiline = false;
         this.rynteTextBox2.Name = "rynteTextBox2";
         this.rynteTextBox2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.rynteTextBox2.PasswordChar = false;
         this.rynteTextBox2.Placeholder = "Placeholder";
         this.rynteTextBox2.ReadOnly = false;
         this.rynteTextBox2.Size = new System.Drawing.Size(218, 26);
         this.rynteTextBox2.TabIndex = 1;
         // 
         // rynteTabControl1
         // 
         this.rynteTabControl1.BorderPageColor = System.Drawing.Color.White;
         this.rynteTabControl1.Controls.Add(this.tabPage1);
         this.rynteTabControl1.Controls.Add(this.tabPage2);
         this.rynteTabControl1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.rynteTabControl1.ItemSize = new System.Drawing.Size(240, 16);
         this.rynteTabControl1.Location = new System.Drawing.Point(238, 13);
         this.rynteTabControl1.Name = "rynteTabControl1";
         this.rynteTabControl1.SelectedIndex = 0;
         this.rynteTabControl1.SelectTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.rynteTabControl1.SelectTextTabColor = System.Drawing.Color.White;
         this.rynteTabControl1.Size = new System.Drawing.Size(195, 128);
         this.rynteTabControl1.TabColor = System.Drawing.Color.Gray;
         this.rynteTabControl1.TabIndex = 2;
         this.rynteTabControl1.TextTabColor = System.Drawing.Color.White;
         // 
         // tabPage1
         // 
         this.tabPage1.Location = new System.Drawing.Point(4, 20);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(187, 104);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "tabPage1";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // tabPage2
         // 
         this.tabPage2.Location = new System.Drawing.Point(4, 20);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(192, 76);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "tabPage2";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // rynteTreeView1
         // 
         this.rynteTreeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
         this.rynteTreeView1.Location = new System.Drawing.Point(238, 147);
         this.rynteTreeView1.Name = "rynteTreeView1";
         treeNode1.Name = "Узел1";
         treeNode1.Text = "Узел1";
         treeNode2.Name = "Узел0";
         treeNode2.Text = "Узел0";
         treeNode3.Name = "Узел3";
         treeNode3.Text = "Узел3";
         treeNode4.Name = "Узел4";
         treeNode4.Text = "Узел4";
         treeNode5.Name = "Узел2";
         treeNode5.Text = "Узел2";
         this.rynteTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5});
         this.rynteTreeView1.SelectFullRow = false;
         this.rynteTreeView1.SelectNodeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.rynteTreeView1.SelectNodeForeColor = System.Drawing.Color.White;
         this.rynteTreeView1.Size = new System.Drawing.Size(195, 76);
         this.rynteTreeView1.TabIndex = 3;
         // 
         // rynteComboBox1
         // 
         this.rynteComboBox1.BorderColor = System.Drawing.Color.Gray;
         this.rynteComboBox1.ButtonColor = System.Drawing.Color.Yellow;
         this.rynteComboBox1.FormattingEnabled = true;
         this.rynteComboBox1.Location = new System.Drawing.Point(13, 148);
         this.rynteComboBox1.Name = "rynteComboBox1";
         this.rynteComboBox1.Size = new System.Drawing.Size(218, 21);
         this.rynteComboBox1.TabIndex = 4;
         // 
         // rynteComboBox2
         // 
         this.rynteComboBox2.BorderColor = System.Drawing.Color.Blue;
         this.rynteComboBox2.ButtonColor = System.Drawing.Color.DimGray;
         this.rynteComboBox2.FormattingEnabled = true;
         this.rynteComboBox2.Location = new System.Drawing.Point(13, 175);
         this.rynteComboBox2.Name = "rynteComboBox2";
         this.rynteComboBox2.Size = new System.Drawing.Size(218, 21);
         this.rynteComboBox2.TabIndex = 5;
         // 
         // rynteComboBox3
         // 
         this.rynteComboBox3.BorderColor = System.Drawing.Color.Magenta;
         this.rynteComboBox3.ButtonColor = System.Drawing.Color.LightGray;
         this.rynteComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.rynteComboBox3.FormattingEnabled = true;
         this.rynteComboBox3.Location = new System.Drawing.Point(13, 202);
         this.rynteComboBox3.Name = "rynteComboBox3";
         this.rynteComboBox3.Size = new System.Drawing.Size(218, 21);
         this.rynteComboBox3.TabIndex = 6;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(445, 236);
         this.Controls.Add(this.rynteComboBox3);
         this.Controls.Add(this.rynteComboBox2);
         this.Controls.Add(this.rynteComboBox1);
         this.Controls.Add(this.rynteTreeView1);
         this.Controls.Add(this.rynteTabControl1);
         this.Controls.Add(this.rynteTextBox2);
         this.Controls.Add(this.rynteTextBox1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.rynteTabControl1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private Rynte.UI2.RynteTextBox rynteTextBox1;
      private Rynte.UI2.RynteTextBox rynteTextBox2;
      private Rynte.UI2.RynteTabControl rynteTabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private Rynte.UI2.RynteTreeView rynteTreeView1;
      private Rynte.UI2.RynteComboBox rynteComboBox1;
      private Rynte.UI2.RynteComboBox rynteComboBox2;
      private Rynte.UI2.RynteComboBox rynteComboBox3;
   }
}

