namespace Uni4._1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtIdentification = new TextBox();
            txtDayAsign = new TextBox();
            txtDaysWorking = new TextBox();
            btnAlmacenRegistro = new Button();
            btnCalcularSalario = new Button();
            label5 = new Label();
            txtTotalDevengado = new TextBox();
            btnNew = new Button();
            btnGetout = new Button();
            error1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel1.Location = new Point(101, 27);
            linkLabel1.Margin = new Padding(7, 0, 7, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(377, 33);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Worker Payroll Calculation\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 81);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(101, 103);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 2;
            label2.Text = "Identification";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(101, 124);
            label3.Name = "label3";
            label3.Size = new Size(182, 21);
            label3.TabIndex = 3;
            label3.Text = "Salary day assignment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 146);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 4;
            label4.Text = "Working Days";
            label4.Click += label4_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(305, 81);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 20);
            txtName.TabIndex = 5;
            // 
            // txtIdentification
            // 
            txtIdentification.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdentification.Location = new Point(305, 107);
            txtIdentification.Multiline = true;
            txtIdentification.Name = "txtIdentification";
            txtIdentification.Size = new Size(191, 20);
            txtIdentification.TabIndex = 6;
            // 
            // txtDayAsign
            // 
            txtDayAsign.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDayAsign.Location = new Point(305, 130);
            txtDayAsign.Multiline = true;
            txtDayAsign.Name = "txtDayAsign";
            txtDayAsign.Size = new Size(191, 20);
            txtDayAsign.TabIndex = 7;
            // 
            // txtDaysWorking
            // 
            txtDaysWorking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDaysWorking.Location = new Point(301, 156);
            txtDaysWorking.Multiline = true;
            txtDaysWorking.Name = "txtDaysWorking";
            txtDaysWorking.Size = new Size(191, 20);
            txtDaysWorking.TabIndex = 8;
            // 
            // btnAlmacenRegistro
            // 
            btnAlmacenRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlmacenRegistro.Location = new Point(305, 194);
            btnAlmacenRegistro.Name = "btnAlmacenRegistro";
            btnAlmacenRegistro.Size = new Size(244, 37);
            btnAlmacenRegistro.TabIndex = 9;
            btnAlmacenRegistro.Text = "Save Employee Record";
            btnAlmacenRegistro.UseVisualStyleBackColor = true;
            btnAlmacenRegistro.Click += btnStorageRegistration_Click;
            // 
            // btnCalcularSalario
            // 
            btnCalcularSalario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcularSalario.Location = new Point(306, 237);
            btnCalcularSalario.Name = "btnCalcularSalario";
            btnCalcularSalario.Size = new Size(243, 30);
            btnCalcularSalario.TabIndex = 10;
            btnCalcularSalario.Text = "Calculate salary";
            btnCalcularSalario.UseVisualStyleBackColor = true;
            btnCalcularSalario.Click += btnCalculateSalary_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(98, 295);
            label5.Name = "label5";
            label5.Size = new Size(152, 21);
            label5.TabIndex = 11;
            label5.Text = "Total Earned Value\r\n";
            // 
            // txtTotalDevengado
            // 
            txtTotalDevengado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalDevengado.Location = new Point(301, 295);
            txtTotalDevengado.Multiline = true;
            txtTotalDevengado.Name = "txtTotalDevengado";
            txtTotalDevengado.Size = new Size(248, 31);
            txtTotalDevengado.TabIndex = 12;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(152, 337);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(119, 45);
            btnNew.TabIndex = 13;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnGetout
            // 
            btnGetout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetout.Location = new Point(277, 337);
            btnGetout.Name = "btnGetout";
            btnGetout.Size = new Size(98, 48);
            btnGetout.TabIndex = 14;
            btnGetout.Text = "Get out";
            btnGetout.UseVisualStyleBackColor = true;
            btnGetout.Click += btnGetOut_Click;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 415);
            Controls.Add(btnGetout);
            Controls.Add(btnNew);
            Controls.Add(txtTotalDevengado);
            Controls.Add(label5);
            Controls.Add(btnCalcularSalario);
            Controls.Add(btnAlmacenRegistro);
            Controls.Add(txtDaysWorking);
            Controls.Add(txtDayAsign);
            Controls.Add(txtIdentification);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtIdentification;
        private TextBox txtDayAsign;
        private TextBox txtDaysWorking;
        private Button btnAlmacenRegistro;
        private Button btnCalcularSalario;
        private Label label5;
        private TextBox txtTotalDevengado;
        private Button btnNew;
        private Button btnGetout;
        private ErrorProvider error1;
    }
}
