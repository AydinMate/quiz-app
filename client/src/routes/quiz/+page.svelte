<script lang="ts">
	import axios from 'axios';
	import AnswerLabel from '$lib/answer-label.svelte';
	import QuestionLabel from '$lib/question-label.svelte';
	import { onMount } from 'svelte';
	import { ProgressRadial } from '@skeletonlabs/skeleton';

	let questions: Question[] = [];

	const getRandomQuestions = async () => {
		const res = await axios.get('http://localhost:5041/get-random-questions');
		questions = res.data;
		console.log(questions);
		return res.data;
	};

	onMount(getRandomQuestions);
</script>

<div class="flex flex-col justify-center items-center h-[100vh]">
	{#if questions.length > 0}
		<h1 class="h1">Question 1 of 5</h1>
		<QuestionLabel question={questions[0].question} />
		<div class="grid grid-cols-2 mt-[8rem] gap-x-[28rem] gap-y-[16rem]">
			{#each questions[0].answers as answer}
				<AnswerLabel {answer} />
			{/each}
		</div>
	{:else}
	<div class="flex flex-col justify-center items-center h-full">
		<ProgressRadial />
	</div>
	{/if}
</div>
