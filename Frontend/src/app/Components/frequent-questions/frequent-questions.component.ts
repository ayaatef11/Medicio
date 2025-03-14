import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  standalone:true,
    selector: 'app-frequent-questions',
    imports: [NgFor],
    templateUrl: './frequent-questions.component.html',
    styleUrl: './frequent-questions.component.css'
})
export class FrequentQuestionsComponent {
  faqs = [
    { id: 'faq1', question: 'Non consectetur a erat nam at lectus urna duis?', answer: 'Feugiat pretium nibh ipsum consequat. Tempus iaculis urna id volutpat lacus laoreet non curabitur gravida. Venenatis lectus magna fringilla urna porttitor rhoncus dolor purus non.' },
    { id: 'faq2', question: 'Feugiat scelerisque varius morbi enim nunc faucibus a pellentesque?', answer: 'Dolor sit amet consectetur adipiscing elit pellentesque habitant morbi. Id interdum velit laoreet id donec ultrices. Fringilla phasellus faucibus scelerisque eleifend donec pretium. Est pellentesque elit ullamcorper dignissim. Mauris ultrices eros in cursus turpis massa tincidunt dui.' },
    { id: 'faq3', question: 'Dolor sit amet consectetur adipiscing elit pellentesque habitant morbi?', answer: 'Eleifend mi in nulla posuere sollicitudin aliquam ultrices sagittis orci. Faucibus pulvinar elementum integer enim. Sem nulla pharetra diam sit amet nisl suscipit. Rutrum tellus pellentesque eu tincidunt. Lectus urna duis convallis convallis tellus. Urna molestie at elementum eu facilisis sed odio morbi quis' },
    { id: 'faq4', question: 'Ac odio tempor orci dapibus. Aliquam eleifend mi in nulla?', answer: 'Dolor sit amet consectetur adipiscing elit pellentesque habitant morbi. Id interdum velit laoreet id donec ultrices. Fringilla phasellus faucibus scelerisque eleifend donec pretium. Est pellentesque elit ullamcorper dignissim. Mauris ultrices eros in cursus turpis massa tincidunt dui.' },
    { id: 'faq5', question: 'Tempus quam pellentesque nec nam aliquam sem et tortor consequat?', answer: 'Molestie a iaculis at erat pellentesque adipiscing commodo. Dignissim suspendisse in est ante in. Nunc vel risus commodo viverra maecenas accumsan. Sit amet nisl suscipit adipiscing bibendum est. Purus gravida quis blandit turpis cursus in' },
    { id: 'faq6', question: 'Tortor vitae purus faucibus ornare. Varius vel pharetra vel turpis nunc eget lorem dolor?', answer: 'Laoreet sit amet cursus sit amet dictum sit amet justo. Mauris vitae ultricies leo integer malesuada nunc vel. Tincidunt eget nullam non nisi est sit amet. Turpis nunc eget lorem dolor sed. Ut venenatis tellus in metus vulputate eu scelerisque. Pellentesque diam volutpat commodo sed egestas egestas fringilla phasellus faucibus. Nibh tellus molestie nunc non blandit massa enim nec.' }
  ];
}
