namespace Rynte.UI2
{
   partial class RynteTextBox
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

      #region Код, автоматически созданный конструктором компонентов

      /// <summary> 
      /// Требуемый метод для поддержки конструктора — не изменяйте 
      /// содержимое этого метода с помощью редактора кода.
      /// </summary>
      private void InitializeComponent()
      {
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // textBox1
         // 
         this.textBox1.BackColor = System.Drawing.Color.White;
         this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBox1.Location = new System.Drawing.Point(7, 6);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(236, 13);
         this.textBox1.TabIndex = 0;
         this.textBox1.Click += new System.EventHandler(this.TextBox1_Click);
         this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
         this.textBox1.Enter += new System.EventHandler(this.TextBox1_Enter);
         this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
         this.textBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
         this.textBox1.MouseEnter += new System.EventHandler(this.TextBox1_MouseEnter);
         this.textBox1.MouseLeave += new System.EventHandler(this.TextBox1_MouseLeave);
         // 
         // RynteTextBox
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.Controls.Add(this.textBox1);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "RynteTextBox";
         this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.Size = new System.Drawing.Size(250, 25);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox textBox1;
   }
}
