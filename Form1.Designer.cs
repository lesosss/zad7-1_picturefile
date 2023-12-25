namespace zad7_1_picturefile
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
            this.btn = new System.Windows.Forms.Button();
            this.pct = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.OpenFileDialog();
            this.file2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(120, 290);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(149, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "Загрузить рисунок";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // pct
            // 
            this.pct.Location = new System.Drawing.Point(103, 68);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(353, 182);
            this.pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct.TabIndex = 2;
            this.pct.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.pct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog file1;
        private System.Windows.Forms.SaveFileDialog file2;
    }
}

