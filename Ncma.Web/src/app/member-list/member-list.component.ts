import { Component, OnInit } from '@angular/core';
import { MemberService } from '../member.service';
import { MemberListItem } from '../memberListItem';
import { Subscription } from '../../../node_modules/rxjs';

@Component({
    selector: 'app-member-list',
    templateUrl: './member-list.component.html',
    styleUrls: ['./member-list.component.css'],
})
export class MemberListComponent implements OnInit {
    constructor(private memberService: MemberService) { }
    busy: Subscription;
    members: MemberListItem[];

    getMembers(): void {
        this.busy = this.memberService
            .getMembers()
            .subscribe(members => this.members = members);
    }

    ngOnInit() {
        this.getMembers();
    }
}
