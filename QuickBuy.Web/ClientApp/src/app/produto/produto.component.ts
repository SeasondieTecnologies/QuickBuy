import { Component } from "@angular/core"
@Component({
  selector: "app-produto",
  template: "<html><body>{{ obterNome() }}</body></html>"
})
export class ProdutoComponent {//Nome das classes começando com maiúsculos por conta da conversão PascalCase
  public nome: string;
  public liberadoParaVenda: boolean;
  //camelCase para variáveis, atributos e nomes das funções


  public obterNome(): string {
    return "Samsung";
  }
}
