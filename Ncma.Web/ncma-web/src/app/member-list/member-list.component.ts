import { Component, OnInit } from '@angular/core';
import { MemberService } from '../member.service';
import { MemberListItem } from '../memberListItem';

@Component({
    selector: 'app-member-list',
    templateUrl: './member-list.component.html',
    styleUrls: ['./member-list.component.css'],
})
export class MemberListComponent implements OnInit {
    constructor(private memberService: MemberService) { }

    members: MemberListItem[];

    getMembers(): void {
        this.memberService.getMembers()
            .subscribe(members => this.members = members);
    }

    ngOnInit() {
        this.getMembers();
    }
}
