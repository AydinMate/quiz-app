<script lang="ts">
	import { createEventDispatcher } from 'svelte';
	import Icon from '@iconify/svelte';
	export let answer: Answer;

	let checked = false;

	const dispatch = createEventDispatcher();

	const handleClick = () => {
		checked = true;
		const event = new CustomEvent('answer-clicked', {
			detail: { answerId: answer.id, questionId: answer.questionId }
		});
		dispatch('answer-clicked', event);
		checked = false;
	};
</script>

<label class="flex items-center space-x-2">
	<button on:click={handleClick}>
		<Icon icon="material-symbols:select" />
	</button>
	<p class="hover:cursor-pointer">{answer.answer}</p>
</label>
