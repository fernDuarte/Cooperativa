namespace Cooperativa
{
    partial class FormDepositos
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label ncuentaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label tcuentaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepositos));
            this.listaDepositosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaDepositosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.ncuentaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tcuentaCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listaDepositosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cantidadLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ncuentaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            tcuentaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaDepositosBindingNavigator)).BeginInit();
            this.listaDepositosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDepositosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(19, 78);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 1;
            cantidadLabel.Text = "Cantidad:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(19, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // ncuentaLabel
            // 
            ncuentaLabel.AutoSize = true;
            ncuentaLabel.Location = new System.Drawing.Point(147, 41);
            ncuentaLabel.Name = "ncuentaLabel";
            ncuentaLabel.Size = new System.Drawing.Size(51, 13);
            ncuentaLabel.TabIndex = 5;
            ncuentaLabel.Text = "Ncuenta:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(328, 41);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // tcuentaLabel
            // 
            tcuentaLabel.AutoSize = true;
            tcuentaLabel.Location = new System.Drawing.Point(19, 120);
            tcuentaLabel.Name = "tcuentaLabel";
            tcuentaLabel.Size = new System.Drawing.Size(50, 13);
            tcuentaLabel.TabIndex = 9;
            tcuentaLabel.Text = "Tcuenta:";
            // 
            // listaDepositosBindingNavigator
            // 
            this.listaDepositosBindingNavigator.AddNewItem = null;
            this.listaDepositosBindingNavigator.BindingSource = this.listaDepositosBindingSource;
            this.listaDepositosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaDepositosBindingNavigator.DeleteItem = null;
            this.listaDepositosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaDepositosBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaDepositosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaDepositosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaDepositosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaDepositosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaDepositosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaDepositosBindingNavigator.Name = "listaDepositosBindingNavigator";
            this.listaDepositosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaDepositosBindingNavigator.Size = new System.Drawing.Size(521, 25);
            this.listaDepositosBindingNavigator.TabIndex = 0;
            this.listaDepositosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listaDepositosBindingNavigatorSaveItem
            // 
            this.listaDepositosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaDepositosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDepositosBindingNavigatorSaveItem.Image")));
            this.listaDepositosBindingNavigatorSaveItem.Name = "listaDepositosBindingNavigatorSaveItem";
            this.listaDepositosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaDepositosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaDepositosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaDepositosBindingNavigatorSaveItem_Click);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDepositosBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(77, 75);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(104, 20);
            this.cantidadTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDepositosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(77, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(44, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // ncuentaTextBox
            // 
            this.ncuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDepositosBindingSource, "Ncuenta", true));
            this.ncuentaTextBox.Location = new System.Drawing.Point(205, 38);
            this.ncuentaTextBox.Name = "ncuentaTextBox";
            this.ncuentaTextBox.Size = new System.Drawing.Size(104, 20);
            this.ncuentaTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaDepositosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(386, 38);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(104, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // tcuentaCheckBox
            // 
            this.tcuentaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaDepositosBindingSource, "Tcuenta", true));
            this.tcuentaCheckBox.Location = new System.Drawing.Point(77, 115);
            this.tcuentaCheckBox.Name = "tcuentaCheckBox";
            this.tcuentaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.tcuentaCheckBox.TabIndex = 10;
            this.tcuentaCheckBox.UseVisualStyleBackColor = true;
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // listaDepositosBindingSource
            // 
            this.listaDepositosBindingSource.DataSource = typeof(BL.Cooperativa.Deposito);
            // 
            // FormDepositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 149);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(ncuentaLabel);
            this.Controls.Add(this.ncuentaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(tcuentaLabel);
            this.Controls.Add(this.tcuentaCheckBox);
            this.Controls.Add(this.listaDepositosBindingNavigator);
            this.Name = "FormDepositos";
            this.Text = "Depositos";
            this.Load += new System.EventHandler(this.FormDepositos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDepositosBindingNavigator)).EndInit();
            this.listaDepositosBindingNavigator.ResumeLayout(false);
            this.listaDepositosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDepositosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaDepositosBindingSource;
        private System.Windows.Forms.BindingNavigator listaDepositosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaDepositosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox ncuentaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.CheckBox tcuentaCheckBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}