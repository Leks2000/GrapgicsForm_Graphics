
namespace GrapgicsForm
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
            this.butGraf = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butGraf
            // 
            this.butGraf.BackColor = System.Drawing.Color.Yellow;
            this.butGraf.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butGraf.Location = new System.Drawing.Point(12, 419);
            this.butGraf.Name = "butGraf";
            this.butGraf.Size = new System.Drawing.Size(171, 50);
            this.butGraf.TabIndex = 0;
            this.butGraf.Text = "Наисовать";
            this.butGraf.UseVisualStyleBackColor = false;
            this.butGraf.Click += new System.EventHandler(this.butGraf_Click);
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.AliceBlue;
            this.butClear.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butClear.Location = new System.Drawing.Point(633, 419);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(171, 50);
            this.butClear.TabIndex = 1;
            this.butClear.Text = "Очистить";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 481);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butGraf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butGraf;
        private System.Windows.Forms.Button butClear;
    }
}

