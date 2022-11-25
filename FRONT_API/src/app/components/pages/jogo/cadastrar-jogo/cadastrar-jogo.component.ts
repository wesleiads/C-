import { ɵNoopAnimationStyleNormalizer, ɵWebAnimationsStyleNormalizer } from "@angular/animations/browser";
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
 
  selecoes!: Selecao[];
  mensagem!: string;
  selecaoIdA!: number;
  selecaoIdB!: number;
  placar!: number;
  placar1!: number;


  constructor(private http: HttpClient, private router: Router, private route: ActivatedRoute, private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.http.get<Selecao[]>("https://localhost:5001/api/selecao/listar").subscribe({
      next: (selecoes) => {
        this.selecoes = selecoes;
   
      },
    });
  }
  alterar(): void {
    let jogo: Jogo = {
      placar:this.placar,
      placar1: this.placar1,
      
    }; 
    this.http.patch<Jogo>(" https://localhost:5001/api/jogo/alterar", jogo)
      .subscribe({
        next: (jogo) => {
          this._snackBar.open("O jogo foi alterado!", "Ok!", {
            horizontalPosition: "center",
            verticalPosition: "top",
          });
          this.router.navigate(["pages/jogo/listar"]);
        }
      });
  }
      
  cadastrar(): void {
    let jogo: Jogo = {
      "selecaoAId": this.selecaoIdA,
      "selecaoBId": this.selecaoIdB,
      }
    /*Configurando a requisição para a API*/
    this.http
      .post<Jogo>(" https://localhost:5001/api/jogo/cadastrar", jogo)
      // Executar a requisição
      .subscribe({
        next: (jogo) => {
          this._snackBar.open("O jogo foi cadastrado!", "Ok!", {
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
