import { Jogo } from 'src/app/models/jogo.model';
import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-listar-jogo",
  templateUrl: "./listar-jogo.component.html",
  styleUrls: ["./listar-jogo.component.css"],
})
export class ListarJogoComponent implements OnInit {
  constructor(private http: HttpClient) { }
  jogos!: Jogo[];
  id!: number;
    
  ngOnInit(): void {
 
    //Configurando a requisição para a API
    this.http.
      get<Jogo[]>(
        "https://localhost:5001/api/jogo/listar"
      )
      // Executar a requisição
      .subscribe({
        next: (jogos) => {
          //Executamos o que for necessário quando a requisição
          //for bem-sucedida
          this.jogos = jogos;

        }
      });
  }
}
