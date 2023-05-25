namespace EasyTask
{
    partial class Frm_Task
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_Add = new Button();
            Btn_Update = new Button();
            Btn_Del = new Button();
            dataGridViewTask = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            IsCompleted = new DataGridViewCheckBoxColumn();
            txtTitle = new TextBox();
            txtDescription = new RichTextBox();
            chkTermine = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).BeginInit();
            SuspendLayout();
            // 
            // Btn_Add
            // 
            Btn_Add.Location = new Point(467, 14);
            Btn_Add.Name = "Btn_Add";
            Btn_Add.Size = new Size(75, 23);
            Btn_Add.TabIndex = 0;
            Btn_Add.Text = "&Ajouter";
            Btn_Add.UseVisualStyleBackColor = true;
            Btn_Add.Click += Btn_Add_Click;
            // 
            // Btn_Update
            // 
            Btn_Update.Location = new Point(467, 43);
            Btn_Update.Name = "Btn_Update";
            Btn_Update.Size = new Size(75, 23);
            Btn_Update.TabIndex = 1;
            Btn_Update.Text = "Modifier";
            Btn_Update.UseVisualStyleBackColor = true;
            Btn_Update.Click += Btn_Update_Click;
            // 
            // Btn_Del
            // 
            Btn_Del.Location = new Point(467, 72);
            Btn_Del.Name = "Btn_Del";
            Btn_Del.Size = new Size(75, 23);
            Btn_Del.TabIndex = 2;
            Btn_Del.Text = "Supprimer";
            Btn_Del.UseVisualStyleBackColor = true;
            Btn_Del.Click += Btn_Del_Click;
            // 
            // dataGridViewTask
            // 
            dataGridViewTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask.Columns.AddRange(new DataGridViewColumn[] { Id, Title, Description, IsCompleted });
            dataGridViewTask.Location = new Point(83, 258);
            dataGridViewTask.Name = "dataGridViewTask";
            dataGridViewTask.RowTemplate.Height = 25;
            dataGridViewTask.Size = new Size(446, 324);
            dataGridViewTask.TabIndex = 3;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Title
            // 
            Title.HeaderText = "Titre";
            Title.Name = "Title";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // IsCompleted
            // 
            IsCompleted.HeaderText = "Terminé";
            IsCompleted.Name = "IsCompleted";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(169, 15);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(274, 23);
            txtTitle.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(169, 60);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(274, 146);
            txtDescription.TabIndex = 6;
            txtDescription.Text = "";
            // 
            // chkTermine
            // 
            chkTermine.AutoSize = true;
            chkTermine.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkTermine.Location = new Point(272, 212);
            chkTermine.Name = "chkTermine";
            chkTermine.Size = new Size(105, 34);
            chkTermine.TabIndex = 7;
            chkTermine.Text = "Terminé";
            chkTermine.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 12);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 8;
            label1.Text = "Titre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 60);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 9;
            label2.Text = "Description";
            // 
            // Frm_Task
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 594);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkTermine);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(dataGridViewTask);
            Controls.Add(Btn_Del);
            Controls.Add(Btn_Update);
            Controls.Add(Btn_Add);
            Name = "Frm_Task";
            Text = "Form1";
            Load += Frm_Task_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Add;
        private Button Btn_Update;
        private Button Btn_Del;
        private DataGridView dataGridViewTask;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewCheckBoxColumn IsCompleted;
        private TextBox txtTitle;
        private RichTextBox txtDescription;
        private CheckBox chkTermine;
        private Label label1;
        private Label label2;
    }
}