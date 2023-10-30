<script lang="ts">
	import { goto } from "$app/navigation";

	export let results: Result[];
</script>

<div class="flex flex-col">
	<h1 class="mx-auto font-bold">Results</h1>
	{#each results as result}
		<div class="flex justify-between space-x-6 m-4">
			<p>{result.question}</p>
			{#if result.isCorrect === true}
				<p>Correct</p>
			{:else}
				<p>Incorrect</p>
			{/if}
		</div>
	{/each}
	<div class="flex justify-end mt-8">
		<button on:click={() => goto("/dashboard")} class="btn variant-filled">Dashboard</button>
	</div>
</div>

<style>
	h1 {
		font-size: 2rem;
		margin-bottom: 10rem;
	}
</style>
