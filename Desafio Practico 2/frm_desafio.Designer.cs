namespace Desafio_Practico_2
{
    partial class frm_desafio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_desafio));
            this.EPvalidaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_dato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.P_AVL = new System.Windows.Forms.Panel();
            this.P_Cola02 = new System.Windows.Forms.Panel();
            this.P_Cola01 = new System.Windows.Forms.Panel();
            this.dgv_cola1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EPvalidaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.P_AVL.SuspendLayout();
            this.P_Cola01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cola1)).BeginInit();
            this.SuspendLayout();
            // 
            // EPvalidaciones
            // 
            this.EPvalidaciones.ContainerControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.splitContainer1.Panel1.Controls.Add(this.btn_salir);
            this.splitContainer1.Panel1.Controls.Add(this.btn_reset);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_dato);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.P_AVL);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 433);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(95, 356);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(14, 356);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Limpiar";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(59, 82);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 1;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(59, 38);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_dato
            // 
            this.txt_dato.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dato.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_dato.Location = new System.Drawing.Point(123, 41);
            this.txt_dato.Name = "txt_dato";
            this.txt_dato.Size = new System.Drawing.Size(100, 22);
            this.txt_dato.TabIndex = 1;
            this.txt_dato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dato_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato";
            // 
            // P_AVL
            // 
            this.P_AVL.BackColor = System.Drawing.Color.Gainsboro;
            this.P_AVL.Controls.Add(this.P_Cola02);
            this.P_AVL.Controls.Add(this.P_Cola01);
            this.P_AVL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_AVL.Location = new System.Drawing.Point(0, 0);
            this.P_AVL.Name = "P_AVL";
            this.P_AVL.Size = new System.Drawing.Size(720, 433);
            this.P_AVL.TabIndex = 2;
            // 
            // P_Cola02
            // 
            this.P_Cola02.BackColor = System.Drawing.Color.Gainsboro;
            this.P_Cola02.Dock = System.Windows.Forms.DockStyle.Right;
            this.P_Cola02.Location = new System.Drawing.Point(576, 0);
            this.P_Cola02.Name = "P_Cola02";
            this.P_Cola02.Size = new System.Drawing.Size(144, 433);
            this.P_Cola02.TabIndex = 1;
            // 
            // P_Cola01
            // 
            this.P_Cola01.BackColor = System.Drawing.Color.Gainsboro;
            this.P_Cola01.Controls.Add(this.dgv_cola1);
            this.P_Cola01.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_Cola01.Location = new System.Drawing.Point(0, 0);
            this.P_Cola01.Name = "P_Cola01";
            this.P_Cola01.Size = new System.Drawing.Size(144, 433);
            this.P_Cola01.TabIndex = 0;
            // 
            // dgv_cola1
            // 
            this.dgv_cola1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cola1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cola1.Location = new System.Drawing.Point(0, 0);
            this.dgv_cola1.Name = "dgv_cola1";
            this.dgv_cola1.Size = new System.Drawing.Size(144, 433);
            this.dgv_cola1.TabIndex = 0;
            // 
            // frm_desafio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 433);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_desafio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMaster";
            ((System.ComponentModel.ISupportInitialize)(this.EPvalidaciones)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.P_AVL.ResumeLayout(false);
            this.P_Cola01.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cola1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider EPvalidaciones;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel P_AVL;
        private System.Windows.Forms.Panel P_Cola02;
        private System.Windows.Forms.Panel P_Cola01;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_dato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_cola1;
    }
}

