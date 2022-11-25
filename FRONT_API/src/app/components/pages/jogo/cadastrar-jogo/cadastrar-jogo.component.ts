import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { MatSnackBar } from "@angular/material/snack-bar";
import { ActivatedRoute, Router } from "@angular/router";
import { Jogo } from "src/app/models/jogo.model";
import { Selecao } from "src/app/models/selecao.model";

@Component({
  selector: "app-cadastrar-jogo",
  templateUrl: "./cadastrar-jogo.component.html",
  styleUrls: ["./cadastrar-jogo.component.css"],
})
export class CadastrarJogoComponent implements OnInit {
  id!: number;
  selecaoA!: Selecao[];
  selecaoB!: Selecao[];
  criadoEm!: string;
  placar!: Number;
  placar1!: Number;   
  mensagem!: string;



  constructor(private http: HttpClient, private router: Router, private route: ActivatedRoute, private _snackBar: MatSnackBar) {}

  ngOnInit(): void {
    this.http.get<Selecao[]>("https://localhost:5001/api/selecao/listar").subscribe({
      next: (selecoes) => {
        this.selecaoA = selecoes;
        
       
   
      },
    });

    this.http.get<Selecao[]>("https://localhost:5001/api/selecao/listar").subscribe({
      next: (selection) => {
        this.selecaoB = selection;
        
       
   
      },
    });
  
  

    this.route.params.subscribe({
      next: (params) => {
        let { id } = params;
        if (id !== undefined) {
          this.http.get<Jogo>(`https://localhost:5001/api/jogo/buscar/${id}`).subscribe({
            next: (aluguel) => {
              this.id = id;
              this.selecaoA;
              this.placar;
              this.placar1;
              this.criadoEm;
             
            },
          });
        }
      },
    });
  }


  alterar(): void {
      let jogo: Jogo = {
      id: this.id,
      placar:this.placar,
      criadoEm: this.criadoEm,
      
    };
    this.http.patch<Jogo>(" https://localhost:5001/api/jogo/alterar", jogo)
      .subscribe({
        next: (jogo) => {
          this._snackBar.open("Aluguel alterado!", "Ok!", {
            horizontalPosition: "center",
            verticalPosition: "top",
          });
        this.router.navigate(["pages/jogo/listar"]);
              
      },
    });
  }
 
  cadastrar(): void {


    let jogo: Jogo = {
      id: this.id,
      placar:this.placar,
      criadoEm: this.criadoEm,
      
    };

    /*Configurando a requisição para a API*/

	
    this.http
      .post<Jogo>(" https://localhost:5001/api/jogo/cadastrar", jogo)
      // Executar a requisição
      .subscribe({
        next: (jogo) => {
          this._snackBar.open("Aluguel cadastrado!", "Ok!", {
            horizontalPosition: "center",
            verticalPosition: "top",
          });

          //Executamos o que for necessário quando a requisição
          //for bem-sucedida

          this.router.navigate(["pages/jogo/listar"]);
        },
        error: (error) => {
          //Executamos o que for necessário quando a requisição
          //for mal-sucedida
          if (error.status === 400) {
            this.mensagem = "Algum erro de validação aconteceu!";
          } else if (error.status === 0) {
            this.mensagem = "A sua API não está rodando!";
          }
         
        },
      });
  }
}