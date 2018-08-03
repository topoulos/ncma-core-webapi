import { Component, OnInit } from '@angular/core';
import { DojoServiceService } from '../dojo-service.service';
import { Dojo } from '../Dojo';

@Component({
    selector: 'app-dojo-list',
    templateUrl: './dojo-list.component.html',
    styleUrls: ['./dojo-list.component.css'],
})
export class DojoListComponent implements OnInit {
    constructor(private dojoService: DojoServiceService) { }

    dojos: Dojo[];

    getDojos(): void {
        this.dojoService.getDojos()
            .subscribe(dojos => this.dojos = dojos);
    }

    ngOnInit() {
        this.getDojos();
    }
}
