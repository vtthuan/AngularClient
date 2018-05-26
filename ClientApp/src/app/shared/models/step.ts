export interface Step {
  $key: string;
  name: string;

  action: string;
  controller: string;

  State: string;
  Url: string;
  Icon: string;
  Order: number;
}
