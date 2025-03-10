export class Doctor {
  constructor(
    public name: string,
    public specialty: string,
    public image: string,
    public socials: { icon: string; url: string }[]
  ) {}
}
