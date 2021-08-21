
namespace FormsApp
{
    partial class StartForm
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
            this.buttonFullScreenForm = new System.Windows.Forms.Button();
            this.buttonCloseEvent = new System.Windows.Forms.Button();
            this.buttonTransparentForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFullScreenForm
            // 
            this.buttonFullScreenForm.Location = new System.Drawing.Point(12, 12);
            this.buttonFullScreenForm.Name = "buttonFullScreenForm";
            this.buttonFullScreenForm.Size = new System.Drawing.Size(186, 23);
            this.buttonFullScreenForm.TabIndex = 0;
            this.buttonFullScreenForm.Text = "Форма на весь экран";
            this.buttonFullScreenForm.UseVisualStyleBackColor = true;
            this.buttonFullScreenForm.Click += new System.EventHandler(this.buttonFullScreenForm_Click);
            // 
            // buttonCloseEvent
            // 
            this.buttonCloseEvent.Location = new System.Drawing.Point(12, 41);
            this.buttonCloseEvent.Name = "buttonCloseEvent";
            this.buttonCloseEvent.Size = new System.Drawing.Size(186, 23);
            this.buttonCloseEvent.TabIndex = 1;
            this.buttonCloseEvent.Text = "Событие закрытия формы";
            this.buttonCloseEvent.UseVisualStyleBackColor = true;
            this.buttonCloseEvent.Click += new System.EventHandler(this.buttonCloseEvent_Click);
            // 
            // buttonTransparentForm
            // 
            this.buttonTransparentForm.Location = new System.Drawing.Point(12, 70);
            this.buttonTransparentForm.Name = "buttonTransparentForm";
            this.buttonTransparentForm.Size = new System.Drawing.Size(186, 23);
            this.buttonTransparentForm.TabIndex = 2;
            this.buttonTransparentForm.Text = "Прозрачная форма";
            this.buttonTransparentForm.UseVisualStyleBackColor = true;
            this.buttonTransparentForm.Click += new System.EventHandler(this.buttonTransparentForm_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTransparentForm);
            this.Controls.Add(this.buttonCloseEvent);
            this.Controls.Add(this.buttonFullScreenForm);
            this.Name = "StartForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFullScreenForm;
        private System.Windows.Forms.Button buttonCloseEvent;
        private System.Windows.Forms.Button buttonTransparentForm;
    }
}

