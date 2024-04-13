namespace Lab_1
{
    partial class MainForm
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
            this.returnAllBtn = new System.Windows.Forms.Button();
            this.sequrityStatus = new System.Windows.Forms.Label();
            this.specialCharsBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loginField = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.passwField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwLength = new System.Windows.Forms.NumericUpDown();
            this.rockyouPassw = new System.Windows.Forms.CheckBox();
            this.notSimilarSymb = new System.Windows.Forms.CheckBox();
            this.specialSymb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwLength)).BeginInit();
            this.SuspendLayout();
            // 
            // returnAllBtn
            // 
            this.returnAllBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.returnAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.returnAllBtn.Location = new System.Drawing.Point(393, 151);
            this.returnAllBtn.Name = "returnAllBtn";
            this.returnAllBtn.Size = new System.Drawing.Size(165, 28);
            this.returnAllBtn.TabIndex = 23;
            this.returnAllBtn.Text = "Вернуть все символы";
            this.returnAllBtn.UseVisualStyleBackColor = false;
            this.returnAllBtn.Click += new System.EventHandler(this.returnAllBtn_Click);
            // 
            // sequrityStatus
            // 
            this.sequrityStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sequrityStatus.AutoSize = true;
            this.sequrityStatus.BackColor = System.Drawing.Color.Transparent;
            this.sequrityStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sequrityStatus.ForeColor = System.Drawing.Color.IndianRed;
            this.sequrityStatus.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.sequrityStatus.Location = new System.Drawing.Point(453, 73);
            this.sequrityStatus.Name = "sequrityStatus";
            this.sequrityStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sequrityStatus.Size = new System.Drawing.Size(112, 18);
            this.sequrityStatus.TabIndex = 22;
            this.sequrityStatus.Text = "Ненадежный! х\r\n";
            this.sequrityStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // specialCharsBox
            // 
            this.specialCharsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.specialCharsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialCharsBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.specialCharsBox.Location = new System.Drawing.Point(369, 118);
            this.specialCharsBox.Name = "specialCharsBox";
            this.specialCharsBox.Size = new System.Drawing.Size(189, 27);
            this.specialCharsBox.TabIndex = 21;
            this.specialCharsBox.Text = "{}[]()/\\\'\"`~,:.<>";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(335, 410);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(203, 35);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Сохранить все\r\n";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loginField
            // 
            this.loginField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loginField.Location = new System.Drawing.Point(74, 334);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(296, 28);
            this.loginField.TabIndex = 19;
            this.loginField.Text = "Логин";
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateBtn.Location = new System.Drawing.Point(415, 256);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(143, 41);
            this.generateBtn.TabIndex = 18;
            this.generateBtn.Text = "Генерировать";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // passwField
            // 
            this.passwField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passwField.Location = new System.Drawing.Point(74, 262);
            this.passwField.Name = "passwField";
            this.passwField.Size = new System.Drawing.Size(296, 28);
            this.passwField.TabIndex = 17;
            this.passwField.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Длина пароля:";
            // 
            // passwLength
            // 
            this.passwLength.Location = new System.Drawing.Point(233, 74);
            this.passwLength.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.passwLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.passwLength.Name = "passwLength";
            this.passwLength.Size = new System.Drawing.Size(120, 22);
            this.passwLength.TabIndex = 15;
            this.passwLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.passwLength.ValueChanged += new System.EventHandler(this.passwLength_ValueChanged);
            // 
            // rockyouPassw
            // 
            this.rockyouPassw.AutoSize = true;
            this.rockyouPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rockyouPassw.Location = new System.Drawing.Point(74, 181);
            this.rockyouPassw.Name = "rockyouPassw";
            this.rockyouPassw.Size = new System.Drawing.Size(279, 24);
            this.rockyouPassw.TabIndex = 14;
            this.rockyouPassw.Text = "Нераспространенный пароль";
            this.rockyouPassw.UseVisualStyleBackColor = true;
            // 
            // notSimilarSymb
            // 
            this.notSimilarSymb.AutoSize = true;
            this.notSimilarSymb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notSimilarSymb.Location = new System.Drawing.Point(74, 151);
            this.notSimilarSymb.Name = "notSimilarSymb";
            this.notSimilarSymb.Size = new System.Drawing.Size(202, 24);
            this.notSimilarSymb.TabIndex = 13;
            this.notSimilarSymb.Text = "Непохожие символы";
            this.notSimilarSymb.UseVisualStyleBackColor = true;
            // 
            // specialSymb
            // 
            this.specialSymb.AutoSize = true;
            this.specialSymb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialSymb.Location = new System.Drawing.Point(74, 121);
            this.specialSymb.Name = "specialSymb";
            this.specialSymb.Size = new System.Drawing.Size(221, 24);
            this.specialSymb.TabIndex = 12;
            this.specialSymb.Text = "Небуквенные символы";
            this.specialSymb.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 519);
            this.Controls.Add(this.returnAllBtn);
            this.Controls.Add(this.sequrityStatus);
            this.Controls.Add(this.specialCharsBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.passwField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwLength);
            this.Controls.Add(this.rockyouPassw);
            this.Controls.Add(this.notSimilarSymb);
            this.Controls.Add(this.specialSymb);
            this.Name = "MainForm";
            this.Text = "Генератор паролей";
            ((System.ComponentModel.ISupportInitialize)(this.passwLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnAllBtn;
        private System.Windows.Forms.Label sequrityStatus;
        private System.Windows.Forms.TextBox specialCharsBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox passwField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown passwLength;
        private System.Windows.Forms.CheckBox rockyouPassw;
        private System.Windows.Forms.CheckBox notSimilarSymb;
        private System.Windows.Forms.CheckBox specialSymb;
    }
}

