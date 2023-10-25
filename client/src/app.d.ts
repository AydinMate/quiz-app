// See https://kit.svelte.dev/docs/types#app
// for information about these interfaces
// and what to do when importing types
declare namespace App {}

declare class Answer {
	id: string;
	question_id: number;
	answer: string;
}

declare class Question {
	id: number;
	question: string;
	correct_answer_id: string;
	answers: Answer[];
}
