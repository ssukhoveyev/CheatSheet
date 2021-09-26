
namespace PrintersFormsApp
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
            this.buttonSelectDefPrinter = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonPrinterList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectDefPrinter
            // 
            this.buttonSelectDefPrinter.Location = new System.Drawing.Point(12, 12);
            this.buttonSelectDefPrinter.Name = "buttonSelectDefPrinter";
            this.buttonSelectDefPrinter.Size = new System.Drawing.Size(260, 23);
            this.buttonSelectDefPrinter.TabIndex = 0;
            this.buttonSelectDefPrinter.Text = "Выбор принтера по умолчанию";
            this.buttonSelectDefPrinter.UseVisualStyleBackColor = true;
            this.buttonSelectDefPrinter.Click += new System.EventHandler(this.buttonSelectDefPrinter_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(12, 41);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(260, 23);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPrinterList
            // 
            this.buttonPrinterList.Location = new System.Drawing.Point(12, 70);
            this.buttonPrinterList.Name = "buttonPrinterList";
            this.buttonPrinterList.Size = new System.Drawing.Size(260, 23);
            this.buttonPrinterList.TabIndex = 2;
            this.buttonPrinterList.Text = "Список принтеров";
            this.buttonPrinterList.UseVisualStyleBackColor = true;
            this.buttonPrinterList.Click += new System.EventHandler(this.buttonPrinterList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPrinterList);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSelectDefPrinter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectDefPrinter;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPrinterList;
    }
}

