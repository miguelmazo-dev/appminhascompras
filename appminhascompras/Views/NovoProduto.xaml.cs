using appminhascompras.Models;

namespace appminhascompras.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try

		{
			Produto p = new Produto
			{
			  Descricao = txt_descricao.Text,
			  Quantidade = double.Parse(txt_quantidade.Text),
			  Preco = double.Parse(txt_preco.Text)

			};

			await App.Db.Insert(p);
			await DisplayAlert("Sucesso!", "Registro inserido", "OK");
		}
		catch (Exception ex) 
		{
			await DisplayAlert("ops", ex.Message, "ok");
		
		
		
		}
    }
}