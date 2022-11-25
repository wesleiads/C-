import { MatSnackBarModule } from "@angular/material/snack-bar";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { HttpClientModule } from "@angular/common/http";
import { MatCardModule } from "@angular/material/card";
import { MatInputModule } from "@angular/material/input";
import { MatSelectModule } from "@angular/material/select";
import { MatButtonModule } from "@angular/material/button";
import { MatDatepickerModule } from "@angular/material/datepicker";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatToolbarModule } from "@angular/material/toolbar";
import { MatIconModule } from "@angular/material/icon";
import { MatSidenavModule } from "@angular/material/sidenav";
import { MatListModule } from "@angular/material/list";
import { MatTableDataSource, MatTableModule } from '@angular/material/table'  


import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CdkTableModule, DataSource } from "@angular/cdk/table";
import { MatSortModule } from "@angular/material/sort";
import { CadastrarSelecaoComponent } from './components/pages/selecao/cadastrar-selecao/cadastrar-selecao.component';
import { CadastrarJogoComponent } from './components/pages/jogo/cadastrar-jogo/cadastrar-jogo.component';
import { ListarJogoComponent } from './components/pages/jogo/listar-jogo/listar-jogo.component';
import { PalpitarJogoComponent } from './components/pages/jogo/palpitar-jogo/palpitar-jogo.component';


@NgModule({
  declarations: [AppComponent,
    CadastrarJogoComponent,
    CadastrarSelecaoComponent,
    ListarJogoComponent,
    PalpitarJogoComponent,
    ],
  
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatButtonModule,
    MatDatepickerModule,
    MatSnackBarModule,
    MatToolbarModule,
    MatIconModule,
    MatSidenavModule,
    MatListModule,
    MatCardModule,
    MatSnackBarModule,
    MatTableModule,
    CdkTableModule,
    MatSortModule,
    
    
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
