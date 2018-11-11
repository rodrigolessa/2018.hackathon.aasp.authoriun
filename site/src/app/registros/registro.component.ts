import {Component} from '@angular/core';
import * as sha256 from 'sha256';
import {ApiService} from '../app.service';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.scss'],
})
export class RegistroComponent {
  title = 'Registro de Obra';
  file: any;
  step: any = 1;
  obra: any = {
    IdGeneroObra: 3,
    Titulo: '',
    Grafica: 'MD60',
    Editora: 'Renova',
    Ano: '2017',
    Volume: '1',
    Edicao: '1',
    LocalPublicacao: 'Locais',
    Observacoes: '',
    Nome: 'ArquivoObraCompleta',
    Extensao: '.AWV',
    Mime: 'Type',
    Tamanho: '722',
    SHA256: 'fd25ec151404709c48da418b70ace3b727f83a608ac7d593b07558a3ebdf7f10',
  };
  idUltimaObra: any;
  ultimaObra: any;
  loading: any = false;
  visualizarObra: any = false;

  constructor(public apiService: ApiService) {
    this.obterUltimaObra();
  }

  filesChanged(e) {
    this.file = e.target.files[0];
    this.step = 2;
    this.visualizarObra = false;
  }

  anterior(step: any) {
    this.step = step - 1;

    if (this.step === 1) {
      this.file = null;
    }
  }

  proximo(step: any) {
    this.step = step + 1;
  }

  registarObra() {
    this.apiService
      .post(`api/RegistraObra`, this.obra, {})
      .subscribe((data: any) => {
        this.loading = true;
        this.ultimaObra = null;
        localStorage.setItem('idUltimaObra', JSON.stringify(data));
        console.log(data);

        const refreshIntervalId = setInterval(() => {
          this.obterUltimaObra();

          if (this.ultimaObra != null && this.ultimaObra.Registro[0].Status !== 1) {
            this.loading = false;
            this.visualizarObra = true;
            this.step = 1;
            this.file = null;
            clearInterval(refreshIntervalId);
          }
        }, 5000);

        // const r = new FileReader();
        // r.onloadend = function(x) {
        //   let l = '';
        //   const m = new Uint8Array(r.result);
        //   const o = m.byteLength;

        //   for (let p = 0; p < o; p++) {
        //     l += String.fromCharCode(m[p]);
        //   }

        //   const hash = sha256(l);

        //   console.log('sha256', hash);
        // };
        // r.readAsArrayBuffer(this.file);
      });
  }

  obterUltimaObra() {
    if (
      localStorage.getItem('idUltimaObra') !== null &&
      localStorage.getItem('idUltimaObra') !== ''
    ) {
      this.idUltimaObra = JSON.parse(localStorage.getItem('idUltimaObra'));

      this.apiService
        .get(`api/obras?id=` + this.idUltimaObra, null, {})
        .subscribe((data: any) => {
          this.ultimaObra = data;
          console.log(data);
        });
    }
  }
}
