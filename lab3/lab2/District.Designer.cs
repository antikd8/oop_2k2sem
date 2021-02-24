
namespace lab2
{
    partial class District
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
            this.labelDistrict = new System.Windows.Forms.Label();
            this.textBoxAddDistrict = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDistrict
            // 
            this.labelDistrict.AutoSize = true;
            this.labelDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDistrict.Location = new System.Drawing.Point(47, 30);
            this.labelDistrict.Name = "labelDistrict";
            this.labelDistrict.Size = new System.Drawing.Size(237, 20);
            this.labelDistrict.TabIndex = 0;
            this.labelDistrict.Text = "Введите название района:";
            // 
            // textBoxAddDistrict
            // 
            this.textBoxAddDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAddDistrict.Location = new System.Drawing.Point(51, 65);
            this.textBoxAddDistrict.Name = "textBoxAddDistrict";
            this.textBoxAddDistrict.Size = new System.Drawing.Size(233, 26);
            this.textBoxAddDistrict.TabIndex = 1;
            this.textBoxAddDistrict.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddDistrict_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(101, 148);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 50);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "ДОБАВИТЬ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonAdd.MouseEnter += new System.EventHandler(this.buttonAdd_MouseEnter);
            this.buttonAdd.MouseLeave += new System.EventHandler(this.buttonAdd_MouseLeave);
            // 
            // District
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(343, 228);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAddDistrict);
            this.Controls.Add(this.labelDistrict);
            this.Name = "District";
            this.Text = "District";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDistrict;
        private System.Windows.Forms.TextBox textBoxAddDistrict;
        private System.Windows.Forms.Button buttonAdd;
    }
}