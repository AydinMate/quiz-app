<script lang="ts">
	import axios from 'axios';
	import AnswerLabel from '$lib/answer-label.svelte';
	import QuestionLabel from '$lib/question-label.svelte';
	import { onMount } from 'svelte';
	import { ProgressRadial } from '@skeletonlabs/skeleton';
	import { hi } from './+page.server';

	let questions: Question[] = [];
	let questionNumber = 0;

	const getRandomQuestions = async () => {
		const res = await axios.get('http://localhost:5041/get-random-questions');
		questions = res.data;
	};

	onMount(getRandomQuestions);

	const handleAnswerClicked = (event: any) => {
		const chosenAnswerId = event.detail.detail.answerId;
		const questionId = event.detail.detail.questionId;
		console.log('chosen answer: ', chosenAnswerId, 'question id: ', questionId);
		questionNumber += 1;

		if (questionNumber === questions.length) {
			hi(questionNumber);
		}
	};
</script>

<div class="flex flex-col justify-center items-center h-[100vh]">
	{#if questions.length > 0}
		<h1 class="h1">Question {questionNumber + 1} of {questions.length}</h1>
		<QuestionLabel question={questions[questionNumber].question} />
		<div class="grid grid-cols-2 mt-[8rem] gap-x-[24rem] gap-y-[8rem]">
			{#each questions[questionNumber].answers as answer}
				<AnswerLabel {answer} on:answer-clicked={handleAnswerClicked} />
			{/each}
		</div>
	{:else}
		<div class="flex flex-col justify-center items-center h-full">
			<ProgressRadial />
		</div>
	{/if}
</div>
