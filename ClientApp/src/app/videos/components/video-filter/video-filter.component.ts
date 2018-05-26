import { Component, OnInit, Input } from '@angular/core';
import { CategoryService } from "../../../shared/services/category.service";
import { Category } from "../../../shared/models/category";

@Component({
  selector: 'video-filter',
  templateUrl: './video-filter.component.html',
  styleUrls: ['./video-filter.component.css']
})
export class VideoFilterComponent implements OnInit {
  categories$;
  @Input('category') category;

  constructor(categoryService: CategoryService) {
    this.categories$ = categoryService.getAll();
  }

  ngOnInit() {
  }

}
