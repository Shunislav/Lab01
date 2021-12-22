
namespace Lab01
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
            this.pickF = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddF = new System.Windows.Forms.Button();
            this.Dell = new System.Windows.Forms.Button();
            this.DrawPanel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pickF
            // 
            this.pickF.FormattingEnabled = true;
            this.pickF.Location = new System.Drawing.Point(71, 12);
            this.pickF.Name = "pickF";
            this.pickF.Size = new System.Drawing.Size(121, 21);
            this.pickF.TabIndex = 0;
            this.pickF.Text = "pickF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pick Figure";
            // 
            // AddF
            // 
            this.AddF.Location = new System.Drawing.Point(198, 10);
            this.AddF.Name = "AddF";
            this.AddF.Size = new System.Drawing.Size(75, 23);
            this.AddF.TabIndex = 2;
            this.AddF.Text = "AddF";
            this.AddF.UseVisualStyleBackColor = true;
            this.AddF.Click += new System.EventHandler(this.Add);
            // 
            // Dell
            // 
            this.Dell.Location = new System.Drawing.Point(279, 10);
            this.Dell.Name = "Dell";
            this.Dell.Size = new System.Drawing.Size(75, 23);
            this.Dell.TabIndex = 3;
            this.Dell.Text = "Dell";
            this.Dell.UseVisualStyleBackColor = true;
            this.Dell.Click += new System.EventHandler(this.Dell_Click);
            // 
            // DrawPanel
            // 
            this.DrawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.Location = new System.Drawing.Point(0, 39);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(377, 240);
            this.DrawPanel.TabIndex = 4;
            this.DrawPanel.TabStop = false;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseDown);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 282);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.Dell);
            this.Controls.Add(this.AddF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickF);
            this.Name = "Form1";
            this.Text = "Lab01";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pickF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddF;
        private System.Windows.Forms.Button Dell;
        private System.Windows.Forms.PictureBox DrawPanel;
    }
}

