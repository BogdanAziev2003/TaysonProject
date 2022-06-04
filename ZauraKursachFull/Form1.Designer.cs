
namespace ZauraKursachFull
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
            this.MainTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTB
            // 
            this.MainTB.Location = new System.Drawing.Point(12, 59);
            this.MainTB.Name = "MainTB";
            this.MainTB.Size = new System.Drawing.Size(355, 20);
            this.MainTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Через пробел введите числа, которые хотите отсортировать";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainBTN
            // 
            this.MainBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainBTN.Location = new System.Drawing.Point(125, 100);
            this.MainBTN.Name = "MainBTN";
            this.MainBTN.Size = new System.Drawing.Size(126, 42);
            this.MainBTN.TabIndex = 2;
            this.MainBTN.Text = "Отсортировать";
            this.MainBTN.UseVisualStyleBackColor = true;
            this.MainBTN.Click += new System.EventHandler(this.MainBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(379, 159);
            this.Controls.Add(this.MainBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Касакадная сортировка (слиянием)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainBTN;
    }
}

