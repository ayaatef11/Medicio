export class PricingPlan {
  constructor(
    public name: string,
    public price: number,
    public features: { text: string; available: boolean }[],
    public isFeatured: boolean = false,
    public isAdvanced: boolean = false
  ) {}
}
