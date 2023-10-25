<script lang="ts">
	import axios from 'axios';
	import AnswerLabel from '$lib/answer-label.svelte';
	import QuestionLabel from '$lib/question-label.svelte';

	let question: Question = {
		id: 0,
		question: '',
		correct_answer_id: '',
		answers: []
	};

	const getRandomQuestion = async () => {
		const res = await axios.get('http://localhost:5041/get-new-random-question');
		question = res.data;
		return res.data;
	};

    getRandomQuestion()
</script>

<div class="flex flex-col justify-center items-center">
	<h1 class="h1 mt-[4rem]">Question 1 of 5</h1>
	<QuestionLabel question={question.question}/>
	<div class="grid grid-cols-2 mt-[8rem] gap-x-[28rem] gap-y-[16rem]">
		{#each question.answers as answer}
			<AnswerLabel {answer} />
		{/each}
	</div>
</div>
