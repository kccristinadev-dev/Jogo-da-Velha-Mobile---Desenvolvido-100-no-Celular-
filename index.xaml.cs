
// Nome da class
namespace  JogoDaVelha
{
    //
public partial class JogoDaVelha : ContentPage{
        string jogada= "X";
  Button[] campos;
  
  
  //Array de possibilidades
      int[,] vitorias =
{
    {0,1,2},
    {3,4,5},
    {6,7,8},
    {0,3,6},
    {1,4,7},
    {2,5,8},
    {0,4,8},
    {2,4,6}
};  
        
                public JogoDaVelha(){
            
            
 // Indentifica e liga os componentes ao carregar
            InitializeComponent();


// campos do tabuleiro
   campos = new Button[]
{
    campo1_0, campo1_1, campo1_2,
    campo2_0, campo2_1, campo2_2,
    campo3_0, campo3_1, campo3_2
};
            
        }
        
        
        // Função do dos campos do tabuleiro
        private void Jogar(object sender, EventArgs e){
            
      Button bnt =(Button)sender;  
      if(bnt.Text != "")return;
      bnt.Text = jogada;
      
      jogada = jogada == "X" ? "O" : "X";



VerificarVitoria();



    }
    // Valiidar vitoria
    private async void VerificarVitoria()
{
    for (int i = 0; i < 8; i++)
    {
        int a = vitorias[i,0];
        int b = vitorias[i,1];
        int c = vitorias[i,2];

        if (campos[a].Text != "" &&
            campos[a].Text == campos[b].Text &&
            campos[b].Text == campos[c].Text)
        {
 await DisplayAlert("Vitória", $"Jogador {campos[a].Text} venceu!", "OK");
 
 ReiniciarTabuleiro();
 return;
        }
    }
}
// Reiniciar o jogo
private void ReiniciarTabuleiro(){
    foreach(var c in campos){
        c.Text = "";
    c.IsEnabled= true;
    }
    jogada="X";

}

}


}