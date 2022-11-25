import { Selecao } from "./selecao.model";

export interface Jogo {
  id?: number;
  SelecaoA?: Selecao;
  selecaoAId?: number,
  SelecaoB?: Selecao;
  selecaoBId?: number,
  criadoEm?: string;
  placar?: Number;
  placar1?: Number;
}
