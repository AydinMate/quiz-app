<script lang="ts">
	import axios from 'axios';
	import AnswerLabel from '$lib/answer-label.svelte';
	import QuestionLabel from '$lib/question-label.svelte';
	import { onMount } from 'svelte';
	import { ProgressRadial } from '@skeletonlabs/skeleton';
	import Results from '$lib/results.svelte';
	import user from '../../user';
	import { goto } from '$app/navigation';

	let questions: Question[] = [];
	let questionNumber = 1;
	let answersForChecking: AnswerForChecking[] = [];
	let showResults: boolean = false;
	let results: Result[] = [];

	$: isLoggedIn = $user === null || Object.keys($user).length === 0 ? false : true;

	onMount(() => {
		if (!isLoggedIn) {
			goto('/');
		}
	});

	const getRandomQuestions = async () => {
		const res = await axios.get('http://localhost:5041/get-random-questions');
		questions = res.data;
	};

	const sendResponses = async (answersForChecking: AnswerForChecking[]) => {
		try {
			const checkingWithUser: CheckingWithUser = {
				checkAnswers: answersForChecking,
				userId: $user.id
			};

			const res = await axios.post('http://localhost:5041/check-answers', checkingWithUser, {
				headers: {
					'Content-Type': 'application/json'
				}
			});
			results = await res.data;

			console.log(results);
		} catch (error) {
			console.error(error);
		}
	};

	onMount(getRandomQuestions);

	const handleAnswerClicked = (event: any) => {
		const chosenAnswerId = event.detail.detail.answerId;
		const questionId = event.detail.detail.questionId;
		answersForChecking = [
			...answersForChecking,
			{
				question: questions[questionNumber - 1].question,
				answerId: chosenAnswerId,
				questionId: questionId
			}
		];

		if (questionNumber >= questions.length) {
			sendResponses(answersForChecking);
			showResults = true;
		} else {
			questionNumber += 1;
		}
	};
</script>

<div class="flex flex-col justify-center items-center h-[100vh]">
	{#if isLoggedIn}
		{#if showResults === false}
			{#if questions.length > 0}
				<h1 class="h1">Question {questionNumber} of {questions.length}</h1>
				<QuestionLabel question={questions[questionNumber - 1].question} />
				<div class="grid grid-cols-2 mt-[8rem] gap-x-[24rem] gap-y-[8rem]">
					{#each questions[questionNumber - 1].answers as answer}
						<AnswerLabel {answer} on:answer-clicked={handleAnswerClicked} />
					{/each}
				</div>
			{:else}
				<div class="flex flex-col justify-center items-center h-full">
					<ProgressRadial />
				</div>
			{/if}
		{:else if results.length > 0}
			<Results {results} />
		{:else}
			<div class="flex flex-col justify-center items-center h-full">
				<ProgressRadial />
			</div>
		{/if}
	{:else}
		<div class="flex flex-col justify-center items-center h-full">
			<ProgressRadial />
		</div>
	{/if}
</div>