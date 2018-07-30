import { Injectable } from '@angular/core';
import { Dojos } from './mock-dojos';
import { Dojo } from './Dojo';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DojoServiceService {

    public getDojos(): Observable<Dojo[]> {
        return of(Dojos);
    }

    public getDojo(id: number): Observable<Dojo> {
        return of(Dojos.find(dojo => dojo.id === id));
    }

    constructor() { }
}
