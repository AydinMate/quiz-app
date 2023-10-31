<script lang="ts">
	import { goto } from '$app/navigation';
	import { onMount } from 'svelte';
	import user from '../../user';
	import { ProgressRadial } from '@skeletonlabs/skeleton';

	const logout = () => {
		user.update((val) => (val = null));
		goto('/');
	};

	$: isLoggedIn = $user === null || Object.keys($user).length === 0 ? false : true;

	onMount(() => {
		if (!isLoggedIn) {
			goto('/');
		}
	});
</script>

<div class="flex flex-col items-center h-[100vh] space-y-4">
	{#if isLoggedIn}
		<div class="space-y-[4rem]">
			<h1 class="h1 mt-[2rem]">Dashboard</h1>
			<div class="space-x-8 mt-[4rem]">
				<button on:click={() => goto('/quiz')} class="btn variant-filled">Start Quiz</button>
				<button on:click={logout} class="btn variant-filled">Logout</button>
			</div>
		</div>
		<div>
			
		</div>
	{:else}
		<div class="flex flex-col justify-center items-center h-full">
			<ProgressRadial />
		</div>
	{/if}
</div>