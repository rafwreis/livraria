import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';

import { LivroService } from './livro.service';
import { LivroModel } from '../../models/livro.model';
import { HTTPStatusCode } from '../../enums/HTTPStatusCode';
import swal from 'sweetalert2';
import '../../extensao/String';

@Component({
  selector: 'app-livro',
  templateUrl: './livro.component.html',
  styleUrls: ['./livro.component.css']
})
export class LivroComponent implements OnInit {

  livros: LivroModel[];
  frmPesquisa: FormGroup;

  constructor(
    private fb: FormBuilder,
    private livroService: LivroService
  ) { }

  public getLivros(filtro : LivroModel) {

    //this.loadingService.start();
    const sub = this.livroService.getLivro(filtro)
      .subscribe(res => {

        this.livros = res;
        //this.loadingService.stop();
        sub.unsubscribe();

      }, (error) => {

         if (error.status !== HTTPStatusCode.NO_INTERNET_CONNECTION) {
          //   this.raizenError.show(error);

          let obj = {
            a: "error Message"
          };

          console.log(error);
          swal(JSON.parse(JSON.stringify(obj)).a, "error");
         }
      });
  }

  public filtrarClick() {
    let filtro = this.frmPesquisa.value as LivroModel;
    this.getLivros(filtro);
  }

  ngOnInit() {
    this.formPesquisaInit();
    this.filtrarClick();
  }

  private formPesquisaInit() : void {
    this.frmPesquisa = this.fb.group({
      id: String.empty(),
      titulo: String.empty()
   });
  }

  public limparClick(): void {
    this.formPesquisaInit();
  }
}
