import { Component, OnInit } from '@angular/core';
import { LivroModel } from '../../models/livro.model';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LivroService } from '../livro/livro.service';
import swal from 'sweetalert2';
import { Router } from '@angular/router';

@Component({
  selector: 'app-livro-add',
  templateUrl: './livro-add.component.html',
  styleUrls: ['./livro-add.component.css']
})
export class LivroAddComponent implements OnInit {

  livro: LivroModel;
  form: FormGroup;

  constructor(
    private fb: FormBuilder,
    private livroService: LivroService,
    private router: Router
    ) { }

  ngOnInit() {
    this.form = this.fb.group({
      nome: ['']
    });

    this.livro = new LivroModel();
  }

  public salvarClick() : void {
    this.livroService.add(this.livro);
    
    swal(
      "Aviso", "Registro salvo com sucesso!", "success")
      .then(() => {
        this.router.navigate(['/livro']);
      });
  }
}
