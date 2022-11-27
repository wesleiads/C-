import { Selecao } from "./selecao.model";

export interface Jogo {
  id?: number;
  SelecaoA?: Selecao;
  SelecaoB?: Selecao;
  criadoEm?: string;
  placar?: Number;
  placar1?: Number;
}
