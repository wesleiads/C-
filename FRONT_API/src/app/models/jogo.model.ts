import { Selecao } from "./selecao.model";

export interface Jogo {
  id?: number;
  selecaoA?: Selecao;
  selecaoAId: number,
  selecaoB?: Selecao;
  selecaoBId: number,
  criadoEm?: string;
  placar?: Number;
  placar1?: Number;
}
