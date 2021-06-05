import { Injectable, Inject } from '@angular/core';
import { Observable, of } from 'rxjs';
import * as _ from 'lodash';
//import { GenericService } from './generic.service';
//import { TrSportTypeModel } from './../models/tr-sport-type-model';
//import { map } from 'rxjs/operators';
import { map, catchError } from 'rxjs/operators';
import { GenericService } from './services/generic.service';
import { TempModel } from './models/temp-type-model';

@Injectable()
export class TempConversionService {

  constructor(private genericService: GenericService) { }

  public convertTemperature(payload: TempModel): Observable<TempModel> {
    
    return this.genericService.add(payload, 'temperatureconversion/converttemperature', '')
      .pipe(map((res: any) => {
        const r: TempModel = res;        
        return res;
      }));
    
  }

  public getTemperature(): Observable<TempModel> {

    return this.genericService.get('temperatureconversion','')
      .pipe(map((res: any) => {
        const r: TempModel = res;
        return res;
      }));

  }

  

}
