namespace NET_LAB_2_BITS_241_Zaritskaya
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Task2 = new System.Windows.Forms.Button();
            this.Task1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лабораторная работа № 2\r\n\r\n«Разработка визуальных пользовательских интерфейсов дл" +
    "я программирования ввода-вывода и основных операторов языка C# на платформе .NET" +
    " Framework»";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(832, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите задание\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // Task2
            // 
            this.Task2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Task2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Task2.Location = new System.Drawing.Point(510, 245);
            this.Task2.Margin = new System.Windows.Forms.Padding(0);
            this.Task2.MaximumSize = new System.Drawing.Size(200, 100);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(200, 95);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Задание 2";
            this.Task2.UseCompatibleTextRendering = true;
            this.Task2.UseVisualStyleBackColor = true;
            this.Task2.Click += new System.EventHandler(this.Task2_Click);
            // 
            // Task1
            // 
            this.Task1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Task1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Task1.Location = new System.Drawing.Point(125, 245);
            this.Task1.Margin = new System.Windows.Forms.Padding(0);
            this.Task1.MaximumSize = new System.Drawing.Size(200, 100);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(200, 95);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Задание 1";
            this.Task1.UseCompatibleTextRendering = true;
            this.Task1.UseVisualStyleBackColor = true;
            this.Task1.Click += new System.EventHandler(this.Task1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.Task1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Task2;
        private System.Windows.Forms.Button Task1;
    }
}

