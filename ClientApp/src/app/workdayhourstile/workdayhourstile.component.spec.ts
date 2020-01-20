/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { WorkdayhourstileComponent } from './workdayhourstile.component';

let component: WorkdayhourstileComponent;
let fixture: ComponentFixture<WorkdayhourstileComponent>;

describe('workdayhourstile component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ WorkdayhourstileComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(WorkdayhourstileComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});