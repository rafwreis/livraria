import { Injectable } from '@angular/core';
import { Http, RequestOptions, Headers } from '@angular/http';

import { LivroModel } from '../../models/livro.model';
import { APP_API } from '../../app.api';

import { Observable, Subject } from 'rxjs';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Injectable({
  providedIn: 'root'
})
export class LivroService {

  // private headers: Headers = new Headers({  });
  // private options = new RequestOptions({ headers: this.headers });

  constructor(private http: Http) { }

  getLivro(filtro: LivroModel) : Observable<LivroModel[]> {
    return this.http.get(`${APP_API}/livros`)
      .map(response => response.json());
  }

  add(livro: LivroModel) : void {
    this.http.post(`${APP_API}/livros/`, livro)
      .subscribe();
  }
}