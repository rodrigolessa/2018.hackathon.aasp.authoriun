import {Component} from '@angular/core';
import {ApiService} from '../app.service';

@Component({
  selector: 'app-anterioridade',
  templateUrl: './anterioridade.component.html',
  styleUrls: ['./anterioridade.component.scss'],
})
export class AnterioridadeComponent {
  title = 'Anterioridade';
  textoBusca = '';
  obras: any[];

  constructor(public apiService: ApiService) {}

  obterAnterioridade() {
    this.apiService
      .get('api/ConsultaObra?texto=' + this.textoBusca, null, {})
      .subscribe((data: any) => {
        this.obras = data;
        console.log(data);
      });
  }
}
