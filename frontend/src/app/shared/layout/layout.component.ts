import { ChangeDetectorRef, Component, OnDestroy, ViewChild } from '@angular/core';
import { MediaMatcher } from '@angular/cdk/layout';
import { MatSidenav } from '@angular/material/sidenav';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.scss']
})
export class LayoutComponent implements OnDestroy {
  @ViewChild('sidenav') sidenav: MatSidenav;
  public isShowSidebar: boolean;
  public mobileQuery: MediaQueryList;
  private mobileQueryListener: () => void;

  constructor(changeDetectorRef: ChangeDetectorRef, media: MediaMatcher) {        //ak je velkost obrazovky max 1024px pozije sa iny sidebar
    this.mobileQuery = media.matchMedia('(max-width: 1024px)');                     
    this.mobileQueryListener = () => changeDetectorRef.detectChanges();
    this.mobileQuery.addListener(this.mobileQueryListener);
    this.isShowSidebar = !this.mobileQuery.matches;
  }

  public ngOnDestroy(): void {                                    //zavriet sidebar
    this.mobileQuery.removeListener(this.mobileQueryListener);
    this.sidenav.close();
  }
}
