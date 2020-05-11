namespace RecordSetProjectForOOAD
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
            this.clbPerson = new System.Windows.Forms.CheckedListBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.rtbMailText = new System.Windows.Forms.RichTextBox();
            this.clbMailing = new System.Windows.Forms.CheckedListBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSendLetters = new System.Windows.Forms.Button();
            this.lblContacts = new System.Windows.Forms.Label();
            this.lblMailingList = new System.Windows.Forms.Label();
            this.lblMailingText = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbPerson
            // 
            this.clbPerson.CheckOnClick = true;
            this.clbPerson.FormattingEnabled = true;
            this.clbPerson.Items.AddRange(new object[] {
            ""});
            this.clbPerson.Location = new System.Drawing.Point(22, 29);
            this.clbPerson.Name = "clbPerson";
            this.clbPerson.Size = new System.Drawing.Size(269, 208);
            this.clbPerson.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(22, 504);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(107, 17);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Фамилия И. О.";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(166, 504);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(22, 524);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(126, 22);
            this.tbFullName.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(169, 524);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(122, 22);
            this.tbEmail.TabIndex = 4;
            // 
            // btAddPerson
            // 
            this.btAddPerson.Location = new System.Drawing.Point(22, 552);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(269, 26);
            this.btAddPerson.TabIndex = 5;
            this.btAddPerson.Text = "Добавить контакт";
            this.btAddPerson.UseVisualStyleBackColor = true;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // rtbMailText
            // 
            this.rtbMailText.BackColor = System.Drawing.SystemColors.Info;
            this.rtbMailText.BulletIndent = 2;
            this.rtbMailText.Location = new System.Drawing.Point(315, 29);
            this.rtbMailText.Name = "rtbMailText";
            this.rtbMailText.Size = new System.Drawing.Size(290, 463);
            this.rtbMailText.TabIndex = 6;
            this.rtbMailText.Text = "Отправлено с помощью индивидульного проректа по OOAD.";
            // 
            // clbMailing
            // 
            this.clbMailing.CheckOnClick = true;
            this.clbMailing.FormattingEnabled = true;
            this.clbMailing.Location = new System.Drawing.Point(22, 301);
            this.clbMailing.Name = "clbMailing";
            this.clbMailing.Size = new System.Drawing.Size(269, 157);
            this.clbMailing.TabIndex = 7;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(22, 239);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(126, 31);
            this.btSend.TabIndex = 8;
            this.btSend.Text = "Добавить";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(22, 584);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(269, 28);
            this.btSave.TabIndex = 11;
            this.btSave.Text = "Обновить контакты";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(315, 504);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 17);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "Message";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(22, 464);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(269, 28);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "Убрать отмеченных";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(163, 239);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(128, 31);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSendLetters
            // 
            this.btSendLetters.BackColor = System.Drawing.Color.YellowGreen;
            this.btSendLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSendLetters.Location = new System.Drawing.Point(315, 552);
            this.btSendLetters.Name = "btSendLetters";
            this.btSendLetters.Size = new System.Drawing.Size(290, 60);
            this.btSendLetters.TabIndex = 15;
            this.btSendLetters.Text = "Отправить";
            this.btSendLetters.UseVisualStyleBackColor = false;
            this.btSendLetters.Click += new System.EventHandler(this.btSendLetters_Click);
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblContacts.Location = new System.Drawing.Point(20, 9);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(72, 17);
            this.lblContacts.TabIndex = 16;
            this.lblContacts.Text = "Контакты";
            // 
            // lblMailingList
            // 
            this.lblMailingList.AutoSize = true;
            this.lblMailingList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMailingList.Location = new System.Drawing.Point(22, 281);
            this.lblMailingList.Name = "lblMailingList";
            this.lblMailingList.Size = new System.Drawing.Size(122, 17);
            this.lblMailingList.TabIndex = 17;
            this.lblMailingList.Text = "Список рассылки";
            // 
            // lblMailingText
            // 
            this.lblMailingText.AutoSize = true;
            this.lblMailingText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMailingText.Location = new System.Drawing.Point(320, 9);
            this.lblMailingText.Name = "lblMailingText";
            this.lblMailingText.Size = new System.Drawing.Size(114, 17);
            this.lblMailingText.TabIndex = 18;
            this.lblMailingText.Text = "Текст Рассылки";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(315, 524);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(290, 17);
            this.lblWarning.TabIndex = 19;
            this.lblWarning.Text = "Отказывает при большом списке адресов.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 616);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblMailingText);
            this.Controls.Add(this.lblMailingList);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.btSendLetters);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.clbMailing);
            this.Controls.Add(this.rtbMailText);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.clbPerson);
            this.Name = "Form1";
            this.Text = "Рассылки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbPerson;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.RichTextBox rtbMailText;
        private System.Windows.Forms.CheckedListBox clbMailing;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSendLetters;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.Label lblMailingList;
        private System.Windows.Forms.Label lblMailingText;
        private System.Windows.Forms.Label lblWarning;
    }
}

