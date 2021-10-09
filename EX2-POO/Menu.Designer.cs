namespace EX2_POO
{
    partial class Menu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbUser = new System.Windows.Forms.Label();
            this.dgvProdcutos1 = new System.Windows.Forms.DataGridView();
            this.dgvProductos2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbtnTodo = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbU = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApass = new System.Windows.Forms.TextBox();
            this.txtNpass = new System.Windows.Forms.TextBox();
            this.txtVpass = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtOrder = new System.Windows.Forms.RichTextBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbOrder = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdcutos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbOrder);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnBill);
            this.tabPage1.Controls.Add(this.rtxtOrder);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvProdcutos1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(655, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venta Nueva";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dgvProductos2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Inventario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(424, 24);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(90, 16);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "Bienvenido ";
            this.lbUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvProdcutos1
            // 
            this.dgvProdcutos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdcutos1.Location = new System.Drawing.Point(17, 17);
            this.dgvProdcutos1.Name = "dgvProdcutos1";
            this.dgvProdcutos1.Size = new System.Drawing.Size(319, 338);
            this.dgvProdcutos1.TabIndex = 0;
            // 
            // dgvProductos2
            // 
            this.dgvProductos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos2.Location = new System.Drawing.Point(58, 115);
            this.dgvProductos2.Name = "dgvProductos2";
            this.dgvProductos2.Size = new System.Drawing.Size(528, 208);
            this.dgvProductos2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.rbtnNombre);
            this.groupBox1.Controls.Add(this.rbtnTodo);
            this.groupBox1.Location = new System.Drawing.Point(58, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(16, 451);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "<--";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbtnTodo
            // 
            this.rbtnTodo.AutoSize = true;
            this.rbtnTodo.Location = new System.Drawing.Point(66, 29);
            this.rbtnTodo.Name = "rbtnTodo";
            this.rbtnTodo.Size = new System.Drawing.Size(50, 17);
            this.rbtnTodo.TabIndex = 0;
            this.rbtnTodo.TabStop = true;
            this.rbtnTodo.Text = "Todo";
            this.rbtnTodo.UseVisualStyleBackColor = true;
            this.rbtnTodo.Click += new System.EventHandler(this.rbtnTodo_Click);
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(202, 29);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnNombre.TabIndex = 1;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(655, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ajustes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbU
            // 
            this.lbU.AutoSize = true;
            this.lbU.Location = new System.Drawing.Point(57, 33);
            this.lbU.Name = "lbU";
            this.lbU.Size = new System.Drawing.Size(43, 13);
            this.lbU.TabIndex = 0;
            this.lbU.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChangePass);
            this.groupBox2.Controls.Add(this.txtVpass);
            this.groupBox2.Controls.Add(this.txtNpass);
            this.groupBox2.Controls.Add(this.txtApass);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbU);
            this.groupBox2.Location = new System.Drawing.Point(166, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificacion de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña Anterior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nueva Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirma nueva contraseña";
            // 
            // txtApass
            // 
            this.txtApass.Location = new System.Drawing.Point(63, 86);
            this.txtApass.Name = "txtApass";
            this.txtApass.Size = new System.Drawing.Size(209, 20);
            this.txtApass.TabIndex = 4;
            this.txtApass.UseSystemPasswordChar = true;
            // 
            // txtNpass
            // 
            this.txtNpass.Location = new System.Drawing.Point(63, 146);
            this.txtNpass.Name = "txtNpass";
            this.txtNpass.Size = new System.Drawing.Size(209, 20);
            this.txtNpass.TabIndex = 5;
            this.txtNpass.UseSystemPasswordChar = true;
            // 
            // txtVpass
            // 
            this.txtVpass.Location = new System.Drawing.Point(63, 210);
            this.txtVpass.Name = "txtVpass";
            this.txtVpass.Size = new System.Drawing.Size(209, 20);
            this.txtVpass.TabIndex = 6;
            this.txtVpass.UseSystemPasswordChar = true;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(60, 251);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(212, 23);
            this.btnChangePass.TabIndex = 7;
            this.btnChangePass.Text = "Aceptar";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su pedido ";
            // 
            // rtxtOrder
            // 
            this.rtxtOrder.Location = new System.Drawing.Point(361, 33);
            this.rtxtOrder.Name = "rtxtOrder";
            this.rtxtOrder.Size = new System.Drawing.Size(278, 94);
            this.rtxtOrder.TabIndex = 2;
            this.rtxtOrder.Text = "";
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(564, 133);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 23);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Facturar";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(483, 133);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Location = new System.Drawing.Point(361, 170);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(49, 13);
            this.lbOrder.TabIndex = 5;
            this.lbOrder.Text = "Factura: ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 476);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.tabControl1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdcutos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.DataGridView dgvProdcutos1;
        private System.Windows.Forms.DataGridView dgvProductos2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnTodo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TextBox txtVpass;
        private System.Windows.Forms.TextBox txtNpass;
        private System.Windows.Forms.TextBox txtApass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbU;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.RichTextBox rtxtOrder;
        private System.Windows.Forms.Label label1;
    }
}