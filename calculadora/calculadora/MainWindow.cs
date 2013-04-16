using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnSumarClicked (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
		int numA;
		int numB;
		int suma;

		numA=int.Parse(this.numero1.Text);
		numB=int.Parse(this.numero2.Text);	
	    suma=numA+numB;
        
		this.resultado.Text=suma.ToString();

	}

	protected void OnBtnRestarClicked (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
	
		int numA;
		int numB;
		int restar;
		numA= int.Parse(this.numero1.Text);
		numB= int.Parse(this.numero2.Text);
	
		restar=numA-numB;
		this.resultado.Text=restar.ToString();
	}

	protected void OnBtnmultClicked (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
	
		int numA;
		int numB;
		int multiplicar;

		numA= int.Parse(this.numero1.Text);
		numB= int.Parse(this.numero2.Text);
		multiplicar=numA*numB;

		this.resultado.Text=multiplicar.ToString();
	}

	protected void OnBtnDivClicked (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
	
		int numA;
		int numB;
		int div;
		numA=int.Parse(this.numero1.Text);
		numB=Int16.Parse(this.numero2.Text);

		if(numA > numB ){   div=numA/numB;               }
		else{     div=numB/numA;   }

			
		this.resultado.Text=div.ToString();
	
	}
}
