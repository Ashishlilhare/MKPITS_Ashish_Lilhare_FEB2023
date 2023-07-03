namespace Registration_from
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxRegistration = new System.Windows.Forms.GroupBox();
            this.textBoxmobileno = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelMobilenumber = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // groupBoxRegistration
            // 
            this.groupBoxRegistration.Controls.Add(this.textBoxmobileno);
            this.groupBoxRegistration.Controls.Add(this.textBoxAge);
            this.groupBoxRegistration.Controls.Add(this.textBoxName);
            this.groupBoxRegistration.Controls.Add(this.labelMobilenumber);
            this.groupBoxRegistration.Controls.Add(this.labelAge);
            this.groupBoxRegistration.Controls.Add(this.labelName);
            this.groupBoxRegistration.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRegistration.Name = "groupBoxRegistration";
            this.groupBoxRegistration.Size = new System.Drawing.Size(322, 106);
            this.groupBoxRegistration.TabIndex = 1;
            this.groupBoxRegistration.TabStop = false;
            this.groupBoxRegistration.Text = "Registration";
            // 
            // textBoxmobileno
            // 
            this.textBoxmobileno.Location = new System.Drawing.Point(84, 68);
            this.textBoxmobileno.MaxLength = 10;
            this.textBoxmobileno.Name = "textBoxmobileno";
            this.textBoxmobileno.Size = new System.Drawing.Size(223, 20);
            this.textBoxmobileno.TabIndex = 5;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(84, 45);
            this.textBoxAge.MaxLength = 3;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(223, 20);
            this.textBoxAge.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(84, 23);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(223, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelMobilenumber
            // 
            this.labelMobilenumber.AutoSize = true;
            this.labelMobilenumber.Location = new System.Drawing.Point(14, 72);
            this.labelMobilenumber.Name = "labelMobilenumber";
            this.labelMobilenumber.Size = new System.Drawing.Size(58, 13);
            this.labelMobilenumber.TabIndex = 2;
            this.labelMobilenumber.Text = "Mobile No.";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(14, 49);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 1;
            this.labelAge.Text = "Age";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(151, 124);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(79, 34);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(236, 124);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 34);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 169);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBoxRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.groupBoxRegistration.ResumeLayout(false);
            this.groupBoxRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxRegistration;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelMobilenumber;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxmobileno;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
    }
}

