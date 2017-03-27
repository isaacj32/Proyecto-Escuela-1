using System;
using System.Windows.Forms;
using System.Drawing;

namespace Proyecto_Escuela
{
    /// <summary>
    /// Controla lo que pasa en la baldosa
    /// </summary>
	public class smTile : PictureBox
    {
        #region Protected member variables
        /// <summary>
        /// La imagen para cuando tiene un elemento en ella
        /// </summary>
		protected Bitmap filledImage;
        /// <summary>
        /// Imagen para cuando no tiene elemento en ella
        /// </summary>
		protected Bitmap emptyImage;
        /// <summary>
        /// Imagen cuando el drag est� encima la baldosa
        /// </summary>
		protected Bitmap overImage;
        /// <summary>
        /// Se�ala si tiene un elemento o no
        /// </summary>
		protected bool hasItem;
        /// <summary>
        /// Indica el orden que lleva la imagen en la secuencia
        /// </summary>
        protected string path;
        #endregion

        #region Empty constructor
        /// <summary>
        /// Carga las imagenes e inicializa la baldosa.
        /// </summary>
		public smTile(string ruta)
        {
            // Carga las imagenes
            path = ruta;
            filledImage = new Bitmap(path);
            emptyImage = new Bitmap(global::Proyecto_Escuela.Properties.Resources.brokenLineSquareBorder);
            overImage = new Bitmap(global::Proyecto_Escuela.Properties.Resources.brokenLineSquareBorderSLT);

            // Inicializa
            hasItem = false;

            // Inicializa los eventos y las propiedades
            this.BackgroundImage = emptyImage;
            this.Height = 120;
            this.Width = 140;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.MouseDown += new MouseEventHandler(OnMouseDown);
            this.DragEnter += new DragEventHandler(OnDragEnter);
            this.DragDrop += new DragEventHandler(OnDragDrop);
            this.DragLeave += new EventHandler(OnDragLeave);
            this.AllowDrop = true;
        }
        #endregion

        public smTile()
        {
            // Carga las imagenes
            filledImage = null;
            emptyImage = new Bitmap(global::Proyecto_Escuela.Properties.Resources.brokenLineSquareBorder);
            overImage = new Bitmap(global::Proyecto_Escuela.Properties.Resources.brokenLineSquareBorderSLT);

            // Inicializa
            hasItem = false;

            // Inicializa los eventos y las propiedades
            this.BackgroundImage = emptyImage;
            this.Height = 120;
            this.Width = 140;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.MouseDown += new MouseEventHandler(OnMouseDown);
            this.DragEnter += new DragEventHandler(OnDragEnter);
            this.DragDrop += new DragEventHandler(OnDragDrop);
            this.DragLeave += new EventHandler(OnDragLeave);
            this.AllowDrop = true;
        }

        #region HasItem
        /// <value>
        /// bool that signals whether this tile contains an item or not (read only)
        /// </value>
		public bool HasItem
        {
            get
            {
                return hasItem;
            }

            set
            {
                this.hasItem = value;
            }
        }
        #endregion

        public Bitmap FilledImage
        {
            get
            {
                return filledImage;
            }
        }

        #region OnDragDrop
        /// <summary>
        /// Maneja el evento DragDrop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public void OnDragDrop(object sender, DragEventArgs e)
        {
            // Cambia el cursor a la flecha
            this.Cursor = Cursors.Default;
            // Coloca in elemento aqu�
            this.filledImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

            PutItem(this.filledImage);
        }
        #endregion

        #region OnDragEnter
        /// <summary>
        /// Maneja el evento DragEnter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public void OnDragEnter(object sender, DragEventArgs e)
        {
            if (hasItem == false)
            {

                // Check to see if we can handle what is being dragged
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                {

                    // Cambia el cursor a la manito
                    this.Cursor = Cursors.Hand;

                    // Permite saber si los efectos pueden realizarse
                    e.Effect = DragDropEffects.Copy;

                    // Cambia la imagen
                    this.BackgroundImage = overImage;
                }
            }
            else
            {
                // Cambia el cursor a la flechita
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region OnDragLeave
        /// <summary>
        /// Maneja el evento OnDragLeave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public void OnDragLeave(object sender, System.EventArgs e)
        {
            // Solo hace algo si la baldosa tiene un elemento
            if (hasItem == false)
            {
                // Reestablece el cursor
                this.Cursor = Cursors.Default;
                // Cambia la imagen a vac�a
                this.BackgroundImage = emptyImage;
            }
        }
        #endregion

        #region OnGiveFeedback
        /// <summary>
        /// Maneja el evento Feedback
        /// </summary>
        /// <param name="gfbEvent"></param>
		protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbEvent)
        {
            // Permite usar nuestros propios cursores cuando estamos arrastrando
            gfbEvent.UseDefaultCursors = false;
        }
        #endregion

        #region OnMouseDown
        /// <summary>
        /// Maneja el evento MouseDown
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">MouseEventArgs</param>
		public void OnMouseDown(object sender, MouseEventArgs e)
        {
            // Solo permite arrastrar si existe un item
            if (hasItem)
            {

                // Inicia el proceso de arrastre
                DragDropEffects effect = DoDragDrop(this.BackgroundImage, DragDropEffects.Copy);

                // Revisa si la imagen fue soltada en algun lado v�lido
                if (effect != DragDropEffects.None)
                {

                    // Fue soltada as� que removemos el item
                    RemoveItem();
                }
            }
        }
        #endregion

        #region PutItem
        /// <summary>
        /// Pone un elemento en la baldosa
        /// </summary>
		public void PutItem(Bitmap bm)
        {
            // Indica la existencia de un item como verdadera
            hasItem = true;
            // Pone la imagen que deber�a tener de relleno
            //this.path = ruta;
            this.BackgroundImage = bm;
        }
        #endregion

        #region RemoveItem
        /// <summary>
        /// Quita el elemento de la baldosa
        /// </summary>
		public void RemoveItem()
        {
            // Indica la existencia del item como falsa
            hasItem = false;
            // Cambia la imagen a la imagen 'vac�a'
            this.BackgroundImage = emptyImage;
        }
        #endregion

        public string Path
        {
            get
            {
                return path;
            }
        }
    }
}