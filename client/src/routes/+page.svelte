<script lang="ts">
	import user from '../user';
	import Login from '../lib/login.svelte';
	import { goto } from '$app/navigation';

	$: isLoggedIn = $user === null || Object.keys($user).length === 0 ? false : true;

	const logout = () => {
		user.update((val) => (val = null));
	};

	$: if (isLoggedIn) {
		goto("/dashboard")
	}
</script>

<div class="container h-full mx-auto flex justify-center items-center p-4">
	<div class="space-y-[6rem] flex flex-col">
		<h1 class="h1 mx-auto">Code Mason's Quiz</h1>
		<div class="">
			{#if !isLoggedIn}
				<Login />
			{:else}
			<div class="flex flex-row justify-center space-x-8">
				<button on:click={logout} class="btn variant-filled">Logout</button><button
					class="btn variant-filled">Dashboard</button
				></div>
			{/if}
		</div>
		<div class="flex flex-col">
			<h1 class="h1 mx-auto">Leaderboard</h1>
		</div>
	</div>
</div>
