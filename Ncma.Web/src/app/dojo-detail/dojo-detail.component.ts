import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { DojoServiceService } from '../dojo-service.service';
import { Dojo } from '../Dojo';

@Component({
    selector: 'app-dojo-detail',
    templateUrl: './dojo-detail.component.html',
    styleUrls: ['./dojo-detail.component.css']
})
export class DojoDetailComponent implements OnInit {
    @Input() dojo: Dojo;

    getDojo(): void {
        const id = +this.route.snapshot.paramMap.get('id');
        this.dojoService.getDojo(id)
            .subscribe(dojo => this.dojo = dojo);
    }

    saveDojo(): void {

    }

    constructor(
        private route: ActivatedRoute,
        private dojoService: DojoServiceService,
        private location: Location
    ) { }

    ngOnInit() {
        this.getDojo();
    }

}
